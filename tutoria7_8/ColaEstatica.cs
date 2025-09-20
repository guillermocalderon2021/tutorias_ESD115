using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria7
{
    internal class ColaEstatica<T>: ICola<T>
    {

        private const int MAX = 10;
        private T[] elementos;
        private int fin;

        public ColaEstatica()
        {
            elementos = new T[MAX];
            fin = -1;
        }

        public bool EstaVacia() => fin == -1;
        public bool EstaLlena() => fin == MAX - 1;

        public bool Encolar(T elemento)
        {
            if (EstaLlena())
            {
                Console.WriteLine("La cola esta llena. No se pudo agregar el elemento");
                return false;
            }

            fin++;
            elementos[fin] = elemento;
            Console.WriteLine("Elemento agregado a la cola de forma exitosa");
            return true;
        }

        public T Desencolar()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La cola esta vacia");
                return default(T);
            }


            T eliminado = elementos[0];
            // Desplazar todos los elementos una posicion a la izquierda
            for(int i=0; i < fin; i++)
            {
                elementos[i] = elementos[i + 1];
            }
      
            fin--;
            return eliminado;
        }

        // Retorna el primer elemento de la cola sin eliminarlo
        public T Peek()
        {
            return elementos[0];
        }

        public void MostrarCola()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La cola esta vacia");
                return;
            }

            for (int i = 0; i <= fin; i++)
            {
                Console.WriteLine(elementos[i]);
            }
        }
    }
}
