using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Lista<Empleado> lista = new Lista<Empleado>();



            do
            {
                Menu();
                Console.Write("Ingrese opción: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = 0; // opción inválida
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        lista.InsertarAlInicio(CrearEmpleado());
                        break;

                    case 2:
                        lista.InsertarAlFinal(CrearEmpleado());
                        break;

                    case 3:
                        lista.MostrarLista();
                        break;

                    case 4:
                        //BuscarEmpleado();
                        break;

                    case 5:
                        int indice;
                        Console.Write("Ingresa el indice del empleado que quieres borrar: ");
                        indice = int.Parse(Console.ReadLine());
                        if (lista.Eliminar(indice))
                        {
                            Console.WriteLine("Empleado eliminado exitosamente");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo eliminar ese empleado");
                        }
                            break;

                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

                if (opcion != 6)
                {
                    Console.WriteLine("\nPresione ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (opcion != 6);
        }

        // Menú principal
        static void Menu()
        {
            Console.WriteLine("\t\tLISTA ENLAZADA SIMPLE\n");
            Console.WriteLine(" 1. Insertar empleado al inicio");
            Console.WriteLine(" 2. Insertar empleado al final");
            Console.WriteLine(" 3. Reportar lista de empleados");
            Console.WriteLine(" 4. Buscar empleado por número");
            Console.WriteLine(" 5. Eliminar empleado por número");
            Console.WriteLine(" 6. Salir");
            Console.WriteLine();
        }

        static Empleado CrearEmpleado()
        {
            Empleado empleado = new Empleado();

            Console.Write("Número de empleado: ");
            empleado.Id = int.Parse(Console.ReadLine());

            Console.Write("Nombre empleado: ");
           empleado.Nombre = Console.ReadLine();

            Console.Write("DUI empleado: ");
            empleado.Dui = Console.ReadLine();

            Console.Write("Departamento empleado: ");
            empleado.Departamento = Console.ReadLine();
            return empleado;
        }

    }
}
