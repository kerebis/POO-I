using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.WriteLine("Informe três valores inteiros e diferentes: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());

            if (A == B || A == C || B == C)
            {
                Console.WriteLine("Os valores informados não são diferentes.");
                return;
            }

            if (A < B)
            {
                if (B < C)
                {
                }
                else
                {
                    int X = A;
                    A = C;
                    C = X;
                }
            }
            else
            {
                if (A < C)
                {
                    int X = B;
                    B = A;
                    A = X;
                }
                else
                {
                    int X = C;
                    C = A;
                    A = X;
                }
            }

            Console.WriteLine("Os valores em ordem decrescente são: {0}, {1}, {2}", A, B, C);

        }
    }
}
