using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria7
{
    internal interface ICola<T>
    {

        bool EstaVacia();
        bool Encolar(T elemento);
        T Desencolar();
        T Peek();
        void MostrarCola();


    }
}
