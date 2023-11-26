using System;
using System.Globalization;

namespace produtosdois {
    class Program {
        static void Main(string[] args) {
            string[] vetA = Console.ReadLine().Split(' ');
            int idA = int.Parse(vetA[0]);
            int qtdA = int.Parse(vetA[1]);
            double valA = double.Parse(vetA[2], CultureInfo.InvariantCulture);

            string[] vetB = Console.ReadLine().Split(' ');
            int idB = int.Parse(vetB[0]);
            int qtdB = int.Parse(vetB[1]);
            double valB = double.Parse(vetB[2], CultureInfo.InvariantCulture);

            double total = valA * qtdA + valB * qtdB;

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
