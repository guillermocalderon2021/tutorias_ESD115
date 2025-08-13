using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria3
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public Persona(string _nombre, string _apellido, int _edad)
        {
            Nombre = _nombre;
            Apellido = _apellido;
            Edad = _edad;
        }
    }
}
