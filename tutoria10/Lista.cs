using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria10
{
    internal class Lista<T>
    {
        public Nodo<T> Primero { get; set; }
        public Nodo<T> Ultimo { get; set; }
        public int Size { get; set; }

        public Lista() { 
            Primero=Ultimo=null;
            Size=0;
        }

        public bool EstaVacia()
        {
            return Primero == null;
        }

        public bool InsertarAlFinal(T elemento)
        {
            Nodo<T> nuevo = new Nodo<T>(elemento);
            if (EstaVacia())
            {
                Primero = Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
            }
            Console.WriteLine("Elemento agregado a la lista de forma exitosa");
            Size++;
            return true;
        }

        public bool InsertarAlInicio(T elemento)
        {
            Nodo<T> nuevo = new Nodo<T>(elemento);
            if (EstaVacia())
            {
                Primero = Ultimo = nuevo;
            }
            else
            {
                nuevo.Siguiente = Primero;
                Primero = nuevo;
            }
            Console.WriteLine("Elemento agregado a la lista de forma exitosa");
            Size++;
            return true;
        }

        public void MostrarLista()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }

            Nodo<T> actual = Primero;
            while (actual != null)
            {
                Console.WriteLine(actual.Valor);
                actual = actual.Siguiente;

            }
        }
        public Nodo<T> Get(int index)
        {
            if (EstaVacia())
            {
                return null;
            }

            Nodo<T> actual = Primero;
            int indiceActual = 0;
            while (actual != null)
            {
                if (indiceActual == index)
                {
                    return actual;
                }
                actual = actual.Siguiente;
                indiceActual++;

            }
            return null;
        }


        public bool Eliminar(int indice)
        {
            if (EstaVacia())
            {
                Console.WriteLine("La lista esta vacia. No se puede eliminar el elemento");
                return false;
            }

            if (indice >= Size)
            {
                Console.WriteLine("No existe esta posicion. No se puede eliminar el elemento");
                return false;
            }
            if (indice == 0) // Eliminando el primer elemento
            {
                Nodo<T> aux = Primero;
                Primero = aux.Siguiente; //Dejando como primero el que antes era el segundo
                aux.Siguiente = null; // rompiendo en enlace a la lista
                Size--;
                return true;
            }
    
            else
            {
                Nodo<T> previo = Get(indice - 1);
                Nodo<T> eliminado = previo.Siguiente;
                previo.Siguiente = eliminado.Siguiente;
                eliminado.Siguiente = null;
                if (indice == Size - 1) // si estamos borrando el ultimo
                {
                    Ultimo = previo;
                }
                Size--;
                return true;
            }


        }

    }

}
