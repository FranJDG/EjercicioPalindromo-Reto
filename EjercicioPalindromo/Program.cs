using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPalindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una palabra:");

            string palabra = Console.ReadLine();

            string palabraInvertida = "";

            for (int i = (palabra.Length - 1); i >= 0 ; i--)
            {
                palabraInvertida += palabra[i];
            }

            if (palabra == palabraInvertida)
            {
                Console.WriteLine($"Tu palabra introducida '{palabra}' es un palíndromo, ya que invertida es igual '{palabraInvertida}'");
            }
            else
            {
                Console.WriteLine($"Tu palabra introducida '{palabra}' no es un palíndromo, ya que invertida no es igual '{palabraInvertida}'");
            }            
        }
    }

}
