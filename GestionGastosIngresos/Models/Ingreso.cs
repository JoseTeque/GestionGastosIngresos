using GestionGastosIngresos.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGastosIngresos.Models
{
    class Ingreso
    {
        public int IdIngreso { get; set; }
        public int  IdTipoIngreso { get; set; }
        public DateTime fecha { get; set; }
        public decimal monto { get; set; }
        public string  descripcion { get; set; }

        public static bool Agregar(Ingreso ingreso, bool editar)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@IdTipoIngreso", ingreso.IdTipoIngreso),
                new Parametro("@fecha", ingreso.fecha),
                new Parametro("@monto", ingreso.monto),
                new Parametro("@descripcion", ingreso.descripcion),
                new Parametro("@editar", editar),
                new Parametro("@idIngreso", ingreso.IdIngreso)

            };
            bool result = DbDatos.Ejecutar("Ingreso_Agregar", parametros);

            return result;
        }


        public static DataTable Listar()
        {
            return DbDatos.Listar("Ingreso_Listar");
        }
    }
}
