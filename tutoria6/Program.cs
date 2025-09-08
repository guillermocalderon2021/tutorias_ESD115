using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilaDinamica pila = new PilaDinamica();
            do
            {
                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine(" -  Registro de alumnos mediante pilas  -");
                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine("  1- Agregar alumno a la pila");
                Console.WriteLine("  2- Desapilar alumno");
                Console.WriteLine("  3- Ver pila");
                Console.WriteLine("  4- Salir");
                Console.Write(" Selecciona una opcion: ");
                int opcion = -1;
                bool correcto = int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        Alumno alumno = new Alumno();
                        Console.WriteLine("Ingresa el nombre del alumno:");
                        alumno.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingresa el carnet:");
                        alumno.Carnet = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa la carrera:");
                        alumno.Carrera = Console.ReadLine();
                        pila.Apilar(alumno);
                        Console.ReadKey();
                        break;
                    case 2:
                        Alumno eliminado = pila.Desapilar();
                        if (eliminado != null)
                        {
                            Console.WriteLine("Elemento desapilado: " + eliminado);
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        pila.MostrarPila();
                        Console.ReadKey();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Selecciona una opcion valida");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
            while (true);
        }
    }
}
