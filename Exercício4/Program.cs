using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;
            int C = 0;

            if (A == B) 
            {
                C = A + B;
            }
            else
            {
                C = A * B;
            }
            Console.WriteLine("O resultado da operação é {0}", C);
        }
    }
}
