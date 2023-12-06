using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;
            char sexo;
            double peso;

            Console.WriteLine("Informe a altura:");
            altura = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o sexo:");
            sexo = Console.ReadLine()[0];

            if (sexo == 'M')
            {
                peso = (72.7 * altura) - 58;
            }
            else
            {
                peso = (62.1 * altura) - 44.7;
            }

            Console.WriteLine("O peso ideal é: {0}", peso);
        }
    }
}
