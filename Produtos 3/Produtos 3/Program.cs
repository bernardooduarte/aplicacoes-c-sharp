using System;
using System.Globalization;

namespace Produtos {
    class Program {
        static void Main(string[] args) {
            string[] compra = Console.ReadLine().Split(' ');
            double codigo = int.Parse(compra[0]);
            int qtd = int.Parse(compra[1]);

            double valortotal;

            if (codigo == 1) {
                valortotal = 4.00 * qtd;
                Console.WriteLine($"Total: R$ {valortotal.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 2) {
                valortotal = 4.50 * qtd;
                Console.WriteLine($"Total: R$ {valortotal.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 3) {
                valortotal = 5.00 * qtd;
                Console.WriteLine($"Total: R$ {valortotal.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 4) {
                valortotal = 2.00 * qtd;
                Console.WriteLine($"Total: R$ {valortotal.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 5) {
                valortotal = 1.50 * qtd;
                Console.WriteLine($"Total: R$ {valortotal.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else {
                Console.WriteLine("CÓDIGO INVÁLIDO");
            }
        }
    }
}
