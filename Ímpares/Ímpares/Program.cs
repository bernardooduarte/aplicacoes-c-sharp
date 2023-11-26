using System;

namespace Impares {
    class Program {
        static void Main(string[] args) {

            int X = int.Parse(Console.ReadLine());

            if (X >= 1 && X <= 1000) {
                for (int i = 1; i <= X; i++) {
                    if (i % 2 != 0) {
                        Console.WriteLine($"{i}");
                    }
                }
            }
            else {
                Console.WriteLine("Erro! Número menor que 1 ou maior que 1000");
            }
        }
    }
}
