using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aluno;
            double n1, n2, n3, mediaEx, mediaFinal;
            string conceito;

            Console.WriteLine("Informe o número de identificação do aluno: ");
            aluno = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe as notas do aluno: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a média dos exercícios: ");
            mediaEx = double.Parse(Console.ReadLine());

            mediaFinal = (n1 + n2 * 2 + n3 * 3 + mediaEx) / 7;

            switch (mediaFinal)
            {
                case mediaFinal >= 90:
                    conceito = "A";
                    Console.WriteLine("Número do aluno: {0}", aluno);
                    Console.WriteLine("Notas: {0}, {1}, {2}", n1, n2, n3);
                    Console.WriteLine("Média dos exercícios: {0}", mediaEx);
                    Console.WriteLine("Média de aproveitamento: {0}", mediaFinal);
                    Console.WriteLine("Conceito: {0}", conceito);
                    Console.WriteLine("Situação: Aprovado");
                    break;
                case mediaFinal >= 75 && mediaFinal < 90:
                    conceito = "B";
                    Console.WriteLine("Número do aluno: {0}", aluno);
                    Console.WriteLine("Notas: {0}, {1}, {2}", n1, n2, n3);
                    Console.WriteLine("Média dos exercícios: {0}", mediaEx);
                    Console.WriteLine("Média de aproveitamento: {0}", mediaFinal);
                    Console.WriteLine("Conceito: {0}", conceito);
                    Console.WriteLine("Situação: Aprovado");
                    break;
                case mediaFinal >= 60 && mediaFinal < 75:
                    conceito = "C";
                    Console.WriteLine("Número do aluno: {0}", aluno);
                    Console.WriteLine("Notas: {0}, {1}, {2}", n1, n2, n3);
                    Console.WriteLine("Média dos exercícios: {0}", mediaEx);
                    Console.WriteLine("Média de aproveitamento: {0}", mediaFinal);
                    Console.WriteLine("Conceito: {0}", conceito);
                    Console.WriteLine("Situação: Aprovado");
                    break;
                case mediaFinal >= 40 && mediaFinal < 60:
                    conceito = "D";
                    Console.WriteLine("Número do aluno: {0}", aluno);
                    Console.WriteLine("Notas: {0}, {1}, {2}", n1, n2, n3);
                    Console.WriteLine("Média dos exercícios: {0}", mediaEx);
                    Console.WriteLine("Média de aproveitamento: {0}", mediaFinal);
                    Console.WriteLine("Conceito: {0}", conceito);
                    Console.WriteLine("Situação: Reprovado");
                    break;
                default:
                    conceito = "E";
                    Console.WriteLine("Número do aluno: {0}", aluno);
                    Console.WriteLine("Notas: {0}, {1}, {2}", n1, n2, n3);
                    Console.WriteLine("Média dos exercícios: {0}", mediaEx);
                    Console.WriteLine("Média de aproveitamento: {0}", mediaFinal);
                    Console.WriteLine("Conceito: {0}", conceito);
                    Console.WriteLine("Situação: Reprovado");
                    break;
            }
        }
    }
}
