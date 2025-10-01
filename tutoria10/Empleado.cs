using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria10
{
    internal class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Dui { get; set; }
        public  string Departamento { get; set; }

        public override string ToString()
        {
            string cadena = "------------------------------\n";
            cadena+=$"Numero: {this.Id}\n";
            cadena += $"Nombre: {this.Nombre}\n";
            cadena += $"DUI: {this.Dui}\n";
            cadena += $"Departamento: {this.Departamento}\n";
            cadena += "------------------------------\n";
            return cadena;

        }
    }
}
