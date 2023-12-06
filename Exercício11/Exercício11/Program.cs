using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tipoPag;
            double preco;
            double valor;

            Console.WriteLine("Informe o código da condição de pagamento: ");
            tipoPag = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço de etiqueta (em reais): ");
            preco = double.Parse(Console.ReadLine());

            switch (tipoPag)
            {
                case 1:
                    valor = preco * 0.9;
                    break;
                case 2:
                    valor = preco * 0.85;
                    break;
                case 3:
                    valor = preco / 2;
                    break;
                case 4:
                    valor = preco * 1.1;
                    break;
                default:
                    Console.WriteLine("Código de pagamento não existe.");
                    return;
            }

            Console.WriteLine("O valor a ser pago é:{0}", valor);
        }
    }
}
