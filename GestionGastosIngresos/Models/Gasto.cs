using GestionGastosIngresos.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGastosIngresos.Models
{
    class Gasto
    {
        public int IdGasto { get; set; }
        public int IdTipoGasto { get; set; }
        public DateTime fecha { get; set; }
        public decimal monto { get; set; }
        public string descripcion { get; set; }

        public static bool Agregar(Gasto gasto, bool editar)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@IdTipoGasto", gasto.IdTipoGasto),
                new Parametro("@fecha", gasto.fecha),
                new Parametro("@monto", gasto.monto),
                new Parametro("@descripcion", gasto.descripcion),
                new Parametro("@editar", editar),
                new Parametro("@idGasto", gasto.IdGasto)
            };

            return DbDatos.Ejecutar("Gasto_Agregar", parametros);
        }
    }
}
