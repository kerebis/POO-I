using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int B = 0;
            Console.WriteLine("Escreva um número");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                B = num + 5;
            }
            else if (num % 3 == 0)
            {
                B = num + 8;
            }
            else
            {
                Console.WriteLine("O número é nulo.");
            }
            Console.WriteLine("O resultado da operação é:{0}", B);
        }
    }
}
