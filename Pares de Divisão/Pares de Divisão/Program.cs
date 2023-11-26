using System;
using System.Globalization;

namespace ParesdeDivisao {
    class Program {
        static void Main(string[] args) {
            Console.Write("Insira a quantidade de pares de números: ");
            int qtd_pares = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd_pares; i++) {
                string[] pares = Console.ReadLine().Split(' ');
                int numerador = int.Parse(pares[0]);
                int denominador = int.Parse(pares[1]);

                double divisao = (double)numerador / denominador;

                if (denominador != 0) {
                    Console.WriteLine($"{divisao.ToString("F1", CultureInfo.InvariantCulture)}");
                }
                else {
                    Console.WriteLine("divisao impossivel");
                }
            }
        }
    }
}