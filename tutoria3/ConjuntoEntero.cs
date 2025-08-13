using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria3
{
    // Ingresar, eliminar, imprimir min, imprimir max, listar elementos, identidficar si un valor esta 
    internal class ConjuntoEntero
    {
        private List<int> listaNumeros = new List<int>();

        public void Ingresar(int num) { 
            listaNumeros.Add(num);
            
            
        }

        public bool Eliminar(int num)
        {
            return listaNumeros.Remove(num);
        }

        public int Min()
        {
            return listaNumeros.Min();
        }

        public int Max()
        {
            return listaNumeros.Max();
        }

        public void Listar()
        {
            if (listaNumeros.Count > 0)
            {
                Console.WriteLine("Los elementos de la lista son: ");
                Console.WriteLine(String.Join(", ",listaNumeros));
            }
            else
            {
                Console.WriteLine("El conjunto esta vacio");
            }
        }

        public bool EncontrarElemento(int num)
        {
            return listaNumeros.Contains(num);
        }




    }
}
