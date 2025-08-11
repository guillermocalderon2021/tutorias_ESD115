using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTutoria2
{
    internal class Comparador
    {

        public static bool Contiene(List<string> lista, string palabra)
        {
            foreach (var item in lista)
            {
                if (item.ToUpper().Equals(palabra.ToUpper())){
                    return true;
                }
            }
            return false;
        }
    }
}
