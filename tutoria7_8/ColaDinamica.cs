using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria7
{
    internal class ColaDinamica<T>: ICola<T>
    {

        Nodo<T> inicio, final; 

        public ColaDinamica()
        {
            inicio= final = null;
        }

        public bool Encolar(T elemento)
        {
            Nodo<T> nuevo = new Nodo<T>(elemento);
            if (EstaVacia())
            {
                inicio = final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
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
            Nodo<T> borrado = inicio;
            inicio = inicio.Siguiente;
            borrado.Siguiente = null;
            return borrado.Valor;

        }

        public bool EstaVacia() => inicio == null;


        public void MostrarCola()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La cola esta vacia");
                return;
            }

            Nodo<T> inicio = this.inicio;
            while (inicio != null)
            {
                Console.WriteLine(inicio.Valor);
                inicio = inicio.Siguiente;
            }
        }

        public T Peek()
        {
            return inicio.Valor;
        }
    }
}

