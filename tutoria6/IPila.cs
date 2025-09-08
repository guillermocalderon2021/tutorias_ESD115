using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria6
{
    internal interface IPila
    {

        bool EstaVacia();
        bool Apilar(Alumno alumno);
        Alumno Desapilar();
        void MostrarPila();

    }
}
