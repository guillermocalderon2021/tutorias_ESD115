using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria11
{
    internal class Alumno
    {
        public int NumeroLista { get; set; }
        public string Carnet { get; set; }
        public decimal Nota { get; set; }

        public override string ToString()
        {
            return $"{this.NumeroLista} - {this.Carnet} - {this.Nota}";
        }
    }
}
