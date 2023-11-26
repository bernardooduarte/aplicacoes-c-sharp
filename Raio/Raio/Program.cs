using System;
using System.Globalization;

namespace Raio {
    class Program {
        static void Main(string[] args) {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double formula = pi * raio * raio;
            Console.WriteLine($"A={formula.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
