using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Escreva um número");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) 
            {
                Console.WriteLine("O número é par.");
            }
            else if (num % 3 == 0) 
            {
                Console.WriteLine("O número é impar.");
            }
            else
            {
                Console.WriteLine("O número é nulo.");
            }
        }
    }
}
