using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaLinealBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Tamanos de las entradas a probar
            int[] sizes = {  500000, 1000000, 5000000,10000000,50000000 };

            foreach (int size in sizes)
            {
                Console.WriteLine($"Tamanio del arreglo: {size} elementos" );
                Console.WriteLine(new string('-',40));
                // Generando numeros aleatorios
                Random random = new Random(42); //Fijando una semilla aleatoria
                int[] data = new int[size];
                for (int i = 0; i < size; i++)
                {
                    data[i] = random.Next(1, size * 10); // Llenando el arreglo con numeros aleatorios


                }
                //Console.WriteLine(String.Join(",", data));
                // Ordenar el arreglo para la busqueda binaria
                int[] copyData = (int[]) data.Clone();
                Array.Sort(copyData);

                //Elemento a buscar
                int objetivo = random.Next(1, size * 10);

                // Busqueda lineal
                Stopwatch sw = Stopwatch.StartNew();
                int resultadoLineal = BusquedaLinealConArregloOrdenado(copyData, objetivo);
                sw.Stop();
                double tiempoLineal = sw.ElapsedTicks;

                //Busqueda binaria
                Stopwatch sw2 = Stopwatch.StartNew();
                int resultadoBinaria=BusquedaBinaria(copyData,objetivo);
                sw2.Stop();
                double tiempoBinaria = sw2.ElapsedTicks;
                Console.WriteLine($"Busqueda lineal: {tiempoLineal:F6} ms encontrada en la posicion {resultadoLineal}");
                Console.WriteLine($"Busqueda binaria: {tiempoBinaria:F15} ms encontrada en la posicion {resultadoBinaria}");
                
                // Comparacion de complejidades algoritmicas
                // Busqueda lineal  - > O(n) - complejidad lineal
                // Busqueda binaria - > O(log(n)) - Complejidad logaritmica


            }


        }

        static int BusquedaLineal(int[] arreglo, int objetivo)
        {
            for (int i = 0;i < arreglo.Length; i++)
            {
                if (arreglo[i] == objetivo)
                {
                    return i;
                }
            }
            return -1;
        }

        static int BusquedaLinealConArregloOrdenado(int[] arreglo, int objetivo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == objetivo)
                {
                    return i;
                }

                if(arreglo[i] > objetivo)
                {
                    return -1;
                }

            }
            return -1;
        }

        static int BusquedaBinaria(int[] arreglo, int objetivo)
        {
            int izquierda = 0;
            int derecha = arreglo.Length - 1;
            while(izquierda <= derecha)
            {
                int central = (izquierda + derecha) / 2;
                if (arreglo[central]==objetivo)
                    return central;
                if (arreglo[central] < objetivo) // Buscamos a la derecha
                    izquierda = central + 1;
                if (arreglo[central] > objetivo)
                    derecha = central - 1;

            }
            return -1; //Elemento no encontrado
        }
    }
}
