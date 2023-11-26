using System;

namespace Soma {
    class Program {
        static void Main(string[] args) {
            int pvalor = int.Parse(Console.ReadLine());
            int svalor = int.Parse(Console.ReadLine());
            int soma = pvalor + svalor;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}