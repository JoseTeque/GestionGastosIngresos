using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Configuration.ConfigurationManager;

namespace GestionGastosIngresos.Clases
{
    class DbDatos
    {
        public static string Conec = ConnectionStrings["ConectionString"].ConnectionString;

        static SqlConnection connection = new SqlConnection(Conec);

        static void abrirConection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) connection.Open();
        }

        static void cerrarConection()
        {
            if (connection.State == System.Data.ConnectionState.Open) connection.Close();
        }

        public static bool Ejecutar(string nombreProcedimiento, List<Parametro> parametros = null)
        {
            try
            {
                abrirConection();
                SqlCommand cmd = new SqlCommand(nombreProcedimiento, connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                if(parametros != null)
                {
                    foreach (var item in parametros)
                    {
                        if (!item.salida)
                        {
                            cmd.Parameters.AddWithValue(item.Nombre, item.valor);
                        }
                        else
                        {
                            cmd.Parameters.Add(item.Nombre,SqlDbType.VarChar,150).Direction = ParameterDirection.Output;
                        }                      
                    }

                   
                }
                int e = cmd.ExecuteNonQuery();

                for (int i = 0; i < parametros.Count; i++)
                {
                    if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                    {
                        string mensaje = cmd.Parameters[i].Value.ToString();
                        if (!string.IsNullOrEmpty(mensaje))
                        {
                            MessageBox.Show(mensaje);
                        }
                    }
                }
                return e > 0 ? true : false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                cerrarConection();
            }
        }

        public static DataTable Listar(string nombreProcedimiento, List<Parametro> parametros = null)
        {
            try
            {
                abrirConection();
                SqlCommand cmd = new SqlCommand(nombreProcedimiento, connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                if (parametros != null)
                {
                    foreach (var item in parametros)
                    {
                            cmd.Parameters.AddWithValue(item.Nombre, item.valor);
                    }


                }

                DataTable dt = new DataTable();
                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                sqlData.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cerrarConection();
            }
        }

        public static void OcultarId(DataGridView dataGrid)
        {
            foreach (DataGridViewColumn column in dataGrid.Columns)
            {
                if (column.Name.Substring(0, 2).ToUpper().Equals("ID"))
                {
                    dataGrid.Columns[column.Index].Visible = false;
                }

            }

        }

        public static void ListarCombo(DataTable origen, string valor, string id, ComboBox box)
        {
            try
            {
                if(box.Items.Count > 0)
                {
                    box.DataSource = null;
                    box.Items.Clear();
                }

                box.DataSource = origen;
                box.DisplayMember = origen.Columns[valor].ColumnName;
                box.ValueMember = origen.Columns[id].ColumnName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
