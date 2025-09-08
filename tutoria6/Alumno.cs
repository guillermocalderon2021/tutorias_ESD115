using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria6
{
    internal class Alumno
    {
        public int Carnet { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }

        public Alumno(int carnet, string nombre, string carrera)
        {
            Carnet = carnet;
            Nombre = nombre;
            Carrera = carrera;
        }

        public Alumno() { 
            this.Carnet = 0;
            this.Nombre = string.Empty;
            this.Carrera = string.Empty;    
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Carnet: {Carnet}, Carrera: {Carrera}";
        }
    }
}
