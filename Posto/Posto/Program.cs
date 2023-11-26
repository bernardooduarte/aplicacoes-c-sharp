using System;

namespace Posto {
    class Program {
        static void Main(string[] args) {
            int codigo = int.Parse(Console.ReadLine());
            int qtdA = 0;
            int qtdG = 0;
            int qtdD = 0;

            while (codigo != 4) {
                if (codigo == 1) {
                    qtdA++;
                }
                else if (codigo == 2) {
                    qtdG++;
                }
                else if (codigo == 3) {
                    qtdD++;
                }
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {qtdA}");
            Console.WriteLine($"Gasolina: {qtdG}");
            Console.WriteLine($"Diesel: {qtdD}");
        }
    }
}
