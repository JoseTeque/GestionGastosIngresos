using GestionGastosIngresos.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGastosIngresos.Models
{
    class Tipo_ingreso
    {
        public int IdTipoIngreso { get; set; }
        public string Denominacion { get; set; }

        public static bool Guardar(Tipo_ingreso tipo_Ingreso,bool editar)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@Denominacion",tipo_Ingreso.Denominacion),
                new Parametro("@IdTipoIngreso",tipo_Ingreso.IdTipoIngreso),
                new Parametro("@Editar",editar)
            };

            return DbDatos.Ejecutar("TipoIngreso_Agregar", parametros);
        }

        public static DataTable Listar()
        {
            return DbDatos.Listar("tipo_ingreso_listar");
        }

        public static void ListarCombo(ComboBox comboBox)
        {
            DbDatos.ListarCombo(Listar(),"Denominacion","IdTipoIngreso", comboBox);
        }
    }
}
