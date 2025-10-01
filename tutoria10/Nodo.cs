using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria10
{
    internal class Nodo<T>
    {
        public T Valor { get; set; }
        public Nodo<T> Siguiente { get; set; }

        public Nodo(T item)
        {
            this.Valor = item;
            this.Siguiente = null;
        }
    }
}
