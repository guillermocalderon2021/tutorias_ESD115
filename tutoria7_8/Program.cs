using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria7
{
    internal class Program
    {
        static void Main(string[] args)
        {

           /* ColaDinamica<string> miCola = new ColaDinamica<string>();
            miCola.Desencolar();
            miCola.Encolar("Guillermo");
            miCola.Encolar("Alejandro");
            miCola.Encolar("Oscar");
            miCola.Encolar("Josue");
            miCola.Desencolar();
            miCola.MostrarCola();*/

            FormContenedores form= new FormContenedores();
            form.ShowDialog();

            
        }
    }
}
