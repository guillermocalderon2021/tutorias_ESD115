using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria11
{
    internal class ListaAlumnos : ListaDoblementeEnlazada<Alumno>
    {
        public bool IngresarAlumno(Alumno nuevo)
        {
            if (EstaVacia())
            {
                this.InsertarAlFinal(nuevo);
                return true;
            }
            Nodo<Alumno> actual = Primero;
            while (actual != null)
            {
                if (actual.Valor.NumeroLista == nuevo.NumeroLista)
                {
                    Console.WriteLine("Ya existe este numero de lista, no se puede insertar");
                    return false;
                }
                else if (actual.Valor.NumeroLista > nuevo.NumeroLista)
                {
                    Nodo<Alumno> nuevoNodo = new Nodo<Alumno>(nuevo);
                    if (actual.Anterior != null)
                    {
                        actual.Anterior.Siguiente = nuevoNodo;
                        nuevoNodo.Anterior = actual.Anterior;
                        nuevoNodo.Siguiente = actual;
                        actual.Anterior = nuevoNodo;
                        this.Size++;
                    }
                    else
                    {
                        //El nuevo es el primero
                        this.InsertarAlInicio(nuevo);
                    }


                    return true;
                }
                actual = actual.Siguiente;
            }
            this.InsertarAlFinal(nuevo);
            return true;

        }


        public bool BorrarPorNumeroLista(int numeroLista)
        {
            if (EstaVacia())
            {
                Console.WriteLine("No se puede borrar. La lista esta vacia");
                return false;
            }
            Nodo<Alumno> actual = Primero;
            while (actual != null)
            {
                if (actual.Valor.NumeroLista == numeroLista)
                {
                    actual.Anterior.Siguiente = actual.Siguiente;
                    actual.Siguiente.Anterior = actual.Anterior;
                    actual.Anterior = null;
                    actual.Siguiente = null;
                    return true;
                }
                else if (actual.Valor.NumeroLista > numeroLista)
                {
                    Console.WriteLine("No se encuentra el elemento en la lista");
                    return false;
                }
                actual = actual.Siguiente;
            }
            return false;

        }

        public void MostrarAprobadosDescendentes()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }
            Nodo<Alumno> actual = Ultimo;
            while (actual != null)
            {
                if (actual.Valor.Nota >= 6)
                {
                    Console.WriteLine(actual.Valor);
                }
                actual = actual.Anterior;
            }
        }
    }
}
