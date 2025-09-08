using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria6
{
    internal class PilaDinamica:IPila
    {
        Nodo tope; // Primera posicion
        
        public PilaDinamica() {
            tope = null;
        }

        public bool Apilar(Alumno alumno)
        {
            Nodo nuevo = new Nodo(alumno);
            nuevo.Siguiente = tope;
            tope = nuevo;
            Console.WriteLine("Alumno agregado a la pila de forma exitosa");
            return true;
        }

        public Alumno Desapilar()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La pila esta vacia");
                return null;
            }
            Nodo borrado = tope;
            tope = borrado.Siguiente;
            borrado.Siguiente = null;
            return borrado.Valor;

        }

        public bool EstaVacia() => tope == null;
        

        public void MostrarPila()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La pila esta vacia");
                return;
            }

            Nodo inicio= tope;
            while (inicio != null)
            {
                Console.WriteLine(inicio.Valor);
                inicio=inicio.Siguiente;
            }
        }
    }
}
