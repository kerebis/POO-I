using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            char sexo;
            string estadoCivil;
            int tempoCasada = 0;

            Console.WriteLine("Informe o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o sexo (M/F): ");
            sexo = Console.ReadLine()[0];

            Console.WriteLine("Informe o estado civil: ");
            estadoCivil = Console.ReadLine();

            if (sexo == 'F' && estadoCivil == "CASADA")
            {
                Console.WriteLine("Informe o tempo de casada (em anos): ");
                tempoCasada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Sexo: {0}", sexo);
            Console.WriteLine("Estado civil: {0}", estadoCivil);
            if (sexo == 'F' && estadoCivil == "CASADA")
            {
                Console.WriteLine("Tempo de casada: {0} anos", tempoCasada);
            }
        }
    }
}
