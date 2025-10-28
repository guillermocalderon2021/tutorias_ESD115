using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombreBusqueda = "";
            Alumno alumno1 = new Alumno{ Nombre="Guillermo", Promedio=7.5M, MateriasAprobadas=10};
            Alumno alumno2 = new Alumno { Nombre = "Jose", Promedio = 7.8M, MateriasAprobadas = 14 };
            Alumno alumno3 = new Alumno { Nombre = "Mario", Promedio = 8.5M, MateriasAprobadas = 10 };
            Alumno alumno4 = new Alumno { Nombre = "Lorena", Promedio = 9.5M, MateriasAprobadas = 25 };
            Alumno alumno5 = new Alumno { Nombre = "Alonso", Promedio = 9.5M, MateriasAprobadas = 25 };
            List<Alumno> listaAlumnos = new List<Alumno>() { alumno1, alumno2, alumno3, alumno4, alumno5};

            OrdenarLista(listaAlumnos);
            Console.WriteLine(listaAlumnos[1].Nombre);

            Console.WriteLine("Ingresa el nombre que deseas buscar: ");
            nombreBusqueda=Console.ReadLine();

            // Busqueda lineal
            /*
            foreach (Alumno alumno in listaAlumnos)
            {
                if (nombreBusqueda.Equals(alumno.Nombre))
                {
                    Console.WriteLine("Alumno encontrado");
                    Console.WriteLine($"Promedio: {alumno.Promedio}");
                    Console.WriteLine($"Materias aprobadas: { alumno.MateriasAprobadas}");
                    return;
                }
            }
            Console.WriteLine("No se ha encontrado este alumno en la lista");*/

            // Busqueda binaria
            int bajo, alto, central;
            bajo = 0;
            alto = listaAlumnos.Count - 1;
            while (bajo <= alto)
            {
                central = (bajo + alto) / 2;
                /*
                 * A.CompareTo(B) devuelve:
                 * Cero si A==B
                 * <0 si A<B
                 * >0 si A>B
                 */
                int comparacion = listaAlumnos[central].Nombre.CompareTo(nombreBusqueda);
                if (comparacion == 0)
                {
                    Console.WriteLine("Alumno encontrado");
                    Console.WriteLine($"Promedio: {listaAlumnos[central].Promedio}");
                    Console.WriteLine($"Materias aprobadas: {listaAlumnos[central].MateriasAprobadas}");
                    return;
                }
                else if (comparacion > 0)
                {
                    alto = central - 1;
                }
                else
                {
                    bajo = central + 1;
                }
            }
            Console.WriteLine("No se ha encontrado este alumno en la lista");




        }

        static void OrdenarLista(List<Alumno> lista)
        {
            lista.Sort((a1, a2) => a1.Nombre.CompareTo(a2.Nombre));
        }
    }
}
