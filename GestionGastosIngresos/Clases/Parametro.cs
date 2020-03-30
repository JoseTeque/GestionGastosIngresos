using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGastosIngresos.Clases
{
    class Parametro
    {
        public string Nombre { get; set; }
        public object valor { get; set; }
        public bool salida { get; set; }

        public Parametro(string nombre, object valor)
        {
            Nombre = nombre;
            this.salida = false ;
            this.valor = valor;
        }

        public Parametro(string nombre)
        {
            Nombre = nombre;
            salida = true;
        }

    }
}
