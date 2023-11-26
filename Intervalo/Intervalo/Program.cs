using System;

namespace Intervalo {
    class Program {
        static void Main(string[] args) {
            Console.Write("Insira a quantidade de valores inteiros: ");
            int qtd = int.Parse(Console.ReadLine());

            int qtd_in = 0;
            int qtd_out = 0;

            for (int i = 1; i <= qtd; i++) {
                Console.Write($"Valor #{i}: ");
                int valores = int.Parse(Console.ReadLine());
                if (valores >= 10 && valores <= 20) {
                    qtd_in++;
                }
                else {
                    qtd_out++;
                }
            }

            Console.WriteLine($"{qtd_in} in");
            Console.WriteLine($"{qtd_out} out");
        }
    }
}
