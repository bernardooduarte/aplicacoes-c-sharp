using System;

namespace Divisores {
    class Program {
        static void Main(string[] args) {

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= num; i++) {
                if (num % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}