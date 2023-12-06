using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;
            int C = 0;

            Console.WriteLine("Insira o primeiro número:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro número:");
            C = int.Parse(Console.ReadLine());

            if ((A + B)<C) 
            {
                Console.WriteLine($"{A}+{B} é menor do que {C}");
             }
            else 
            {
                Console.WriteLine($"{A}+{B} não é menor do que {C}");
            }
            Console.WriteLine("Se desejar sair do programa aperte qualquer tecla e aperte ENTER");
            Console.ReadLine();
        }
    }
}
