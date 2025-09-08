using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria6
{
    internal class PilaEstatica: IPila
    {

        private const int MAX = 10;
        private Alumno[] alumnos;
        private int tope;

        public PilaEstatica()
        {
            alumnos = new Alumno[MAX];
            tope = -1;
        }

        public bool EstaVacia() => tope == -1;
        public bool EstaLlena() => tope == MAX - 1;

        public bool Apilar(Alumno alumno)
        {
            if (EstaLlena())
            {
                Console.WriteLine("La pila esta llena. No se pudo agregar el alumno");
                return false;
            }

            tope++;
            alumnos[tope] = alumno;
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
            Alumno desapilado = alumnos[tope];
            alumnos[tope]=null;
            tope--;
            return desapilado;
        }

        public void MostrarPila()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La pila esta vacia");
                return;
            }

            for(int i = 0; i <= tope; i++)
            {
                Console.WriteLine(alumnos[i]);
            }
        }


    }
}
