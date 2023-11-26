using System;

namespace ParImpar {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
