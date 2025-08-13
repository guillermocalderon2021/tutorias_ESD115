using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            int resultado = 0;
            Persona persona1 = new Persona("Guillermo","Calderon",20);
            resultado=MultiplicarPor10Refencia(ref num);
            Console.WriteLine($"El valor de la variable num es {num}");
            Console.WriteLine($"El valor de la variable resultado es {resultado}");
            Console.WriteLine($"La edad de {persona1.Nombre} es {persona1.Edad}");
            AumentarEdadInmutable(persona1);
            Console.WriteLine($"La edad de {persona1.Nombre} es {persona1.Edad}");

            // Ejercicio 2
            ConjuntoEntero conjunto = new ConjuntoEntero();
            conjunto.Ingresar(10);
            conjunto.Ingresar(20);
            conjunto.Ingresar(7);
            conjunto.Ingresar(14);
            // Console.WriteLine(conjunto.Eliminar(10));
            //Console.WriteLine(conjunto.Eliminar(10));
            //Console.WriteLine(conjunto.Min());
            conjunto.Listar();
            Console.WriteLine(conjunto.EncontrarElemento(7));
            Console.WriteLine(conjunto.EncontrarElemento(77));
        }

        public static int MultiplicarPor10Valor(int numero)
        {
            numero = numero * 10;
            return numero;
        }

        public static int MultiplicarPor10Refencia(ref int numero)
        {
            numero = numero * 10;
            return numero;
        }

        public static void AumentarEdad(Persona p1)
        {
            p1.Edad += 1;
        }

        public static Persona AumentarEdadInmutable(Persona p1)
        {
            Persona p = new Persona ( p1.Nombre, p1.Apellido,p1.Edad );
            p.Edad += 1;
            return p;
        }
    }
}
