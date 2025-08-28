using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena = "";
            Console.WriteLine("Ingresa una cadena");
            cadena= Console.ReadLine();
            bool esPalindromo = EsPalindromo(cadena.ToUpper(),0,cadena.Length-1);
            if(esPalindromo)
                Console.WriteLine($"La cadena {cadena} es palindromo ");
            else
                Console.WriteLine($"La cadena {cadena} NO es palindromo ");
        }

        public static long CalcularFactorial(int n) {
            if (n == 1) return 1;
            return n*CalcularFactorial(n - 1);
        }

        public static bool EsPalindromo(string palabra, int inicio, int final)
        {
            // CASO BASE
            if(inicio>=final) return true;

            // CASO RECURSIVO : Si los caracteres son iguales, seguimos avanzando hacia el centro
            if (palabra[inicio] == palabra[final])
            {
                return EsPalindromo(palabra, inicio + 1, final - 1);
            }
            // Si no coinciden, no es palindromo
            return false;

        }
    }
}
