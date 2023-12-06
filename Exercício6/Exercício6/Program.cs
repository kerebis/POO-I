using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = true;

            if (A && B == true)
            {
                Console.WriteLine("Ambos são verdadeiros");
            }
            else if (A && B == false) 
            {
                Console.WriteLine("Ambos são falsos");
            }
            else 
            {
                Console.WriteLine("Um é verdadeiro e o outro é falso");
            }

        }
    }
}
