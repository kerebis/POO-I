using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;

            Console.WriteLine("Insira um número");
            A = int.Parse(Console.ReadLine());

            if (A > 0)
            {
                B = A * 2;
                Console.WriteLine("O dobro do número positivo é:{0}", B);
            }
            else if (A < 0) 
            {
                B = A * 3;
                Console.WriteLine("O triplo do número negativo é:{0}", B);
            }
            else 
            {
                Console.WriteLine("O numéro é nulo");
            }
        }
    }
}
