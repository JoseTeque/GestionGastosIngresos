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
    class Tipo_gasto
    {
        public int IdTipoGasto { get; set; }
        public string Denominacion { get; set; }

        public static bool Agregar(Tipo_gasto tipo_Gasto, bool editar)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@Denominacion", tipo_Gasto.Denominacion),
                new Parametro("@IdTipoGasto",tipo_Gasto.IdTipoGasto),
                new Parametro("@Editar",editar)
            };

           return DbDatos.Ejecutar("TipoGASTO_Agregar",parametros);

        }

        public static DataTable Listar()
        {
            return DbDatos.Listar("tipo_gasto_listar");
        }

        public static void ListarCombo(ComboBox comboBox)
        {
            DbDatos.ListarCombo(Listar(), "Denominacion", "IdTipoGasto", comboBox);
        }
    }

   
}
