using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso;
            int altura;
            float imc;
            string estado;

            Console.WriteLine("Informe o peso:");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura:");
            altura = int.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            switch (imc)
            {
                case imc < 18.5:
                    estado = "Abaixo do peso.";
                    break;
                case imc < 25:
                    estado = "Peso normal.";
                    break;
                case imc < 30:
                    estado = "Acima do peso.";
                    break;
                default:
                    estado = "Obeso.";
                    break;
            }

            Console.WriteLine("Seu IMC é: {0}", imc);
            Console.WriteLine("Seu estado é: {0}", estado);
        }
    }
}
