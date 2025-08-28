using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria5
{
    internal class Pila
    {
        private Nodo tope;
        private int count;
        public Pila()
        {
            tope = null;
            count = 0;
        }
        public int Count
        {
            get
            {
                return this.count;
            }
        }
        public void Push(int item)
        {
            if (this.tope == null)
            {
                //la pila esta vacia
                this.tope = new Nodo(item);
            }
            else
            {
                Nodo nuevoNodo = new Nodo(item, this.tope); 
                this.tope = nuevoNodo;
            }
            this.count++;
        }
        public int Peek()
        {
            if (this.count == 0)
            {
                // pila vacia
                throw new InvalidOperationException("La pila está vacía, no hay elementos");
            }
            return this.tope.Item;
        }

        public int Pop()
        {
            if (this.count == 0)
            {
                //pila vacia
                throw new InvalidOperationException("La pila esta vacia. No hay elementos");
            }
            int resultado = this.tope.Item;
            this.tope = this.tope.Next;
            this.count--;
            return resultado;
        }
        public void inverso()
        {
            int p;
            Pila paux = new Pila();
            if (this.count == 0)
            {
                // pila vacia
                throw new InvalidOperationException("La pila está vacía, no hay elementos");
            }
            while (this.count > 0)
            {
                p = Pop();
                paux.Push(p);
                Console.WriteLine("numero sacado de pila: " + p + "\n");
            }
        }
    }
}
