using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria6
{
    internal class Nodo
    {
        public Alumno Valor { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Alumno alumno)
        {
            this.Valor = alumno;
            this.Siguiente = null;
        }
    }
}
