using GestionGastosIngresos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGastosIngresos.Formularios
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pcAgregar_Click(object sender, EventArgs e)
        {
            FIngresos tipoIngreso = new FIngresos();
            tipoIngreso.ShowDialog();

            ListarMovimiento();

        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            tabla.SelectedIndex = 1;
            txtAño.Text = DateTime.Now.Year.ToString();
            cboxMes.SelectedIndex = (DateTime.Now.Month - 1);
            ListarMovimiento();
            
        }

        private void ResumenIngreso()
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@Mes", (cboxMes.SelectedIndex + 1) ),
                new Parametro("@Ano", txtAño.Text)
            };

            dataListadoIngresoR.DataSource = DbDatos.Listar("IngresoResumen_Listar", parametros);
        }

        private void ListarMovimiento()
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@Mes", (cboxMes.SelectedIndex + 1) ),
                new Parametro("@Ano", txtAño.Text)
            };

            dataListadoIngresoGasto.DataSource = DbDatos.Listar("Movimiento_Listar", parametros);
            DbDatos.OcultarId(dataListadoIngresoGasto);
            dataListadoIngresoGasto.Columns["Movimiento"].Visible = false;
            dataListadoIngresoGasto.Columns["Descripcion"].Width = 130;

            Pintar();
            ResumenIngreso();
            ResumenGasto();
        }

        private void ResumenGasto()
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@Mes", (cboxMes.SelectedIndex + 1) ),
                new Parametro("@Ano", txtAño.Text)
            };

            dataListadoGastoR.DataSource = DbDatos.Listar("GastoResumen_Listar", parametros);
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            ListarMovimiento();
        }

        private void pbQuitar_Click(object sender, EventArgs e)
        {
            FGastos gastos = new FGastos();
            gastos.ShowDialog();
            ListarMovimiento();
        }

        private void Pintar()
        {
            decimal TIngreso = 0, Tgastos = 0;
            foreach (DataGridViewRow fila in dataListadoIngresoGasto.Rows)
            {
                string movimiento = fila.Cells["Movimiento"].Value.ToString();
                decimal monto = Convert.ToDecimal(fila.Cells["monto"].Value);

                if (movimiento.Equals("I"))
                {
                    fila.DefaultCellStyle.BackColor = Color.Lime;
                    TIngreso += monto;
                }
                else
                {
                    fila.DefaultCellStyle.BackColor = Color.Red;
                    Tgastos += monto;
                }

            }
            txtIngreso.Text = TIngreso.ToString("N2");
            txtGastos.Text = Tgastos.ToString("N2");

            txtSaldo.Text = (TIngreso - Tgastos).ToString("N2");

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string movimiento = dataListadoIngresoGasto.CurrentRow.Cells["Movimiento"].Value.ToString();
            int IdMovimiento = Convert.ToInt32(dataListadoIngresoGasto.CurrentRow.Cells["IdMovimiento"].Value);
            string descripcion = dataListadoIngresoGasto.CurrentRow.Cells["Descripcion"].Value.ToString();
            string monto = dataListadoIngresoGasto.CurrentRow.Cells["monto"].Value.ToString();
            string tipo = dataListadoIngresoGasto.CurrentRow.Cells["tipo"].Value.ToString();
            string fecha = dataListadoIngresoGasto.CurrentRow.Cells["fecha"].Value.ToString();

            if (movimiento.Equals("I"))
            {
                FIngresos ingresos = new FIngresos();
                ingresos.IdIngreso = IdMovimiento;
                ingresos.txtDescripcion.Text = descripcion;
                ingresos.txtMonto.Text = monto;
                ingresos.tipo = tipo;
                ingresos.dtpFecha.Value = Convert.ToDateTime(fecha); 
                ingresos.Editar = true;
                ingresos.ShowDialog();
            }
            else
            {
                FGastos gastos = new FGastos();
                gastos.IdGasto = IdMovimiento;
                gastos.txtDescripcion.Text = descripcion;
                gastos.txtMonto.Text = monto;
                gastos.dtpFecha.Value = Convert.ToDateTime(fecha);
                gastos.tipo = tipo;
                gastos.Editar = true;
                gastos.ShowDialog();
            }

            ListarMovimiento();
        }
    }
}
