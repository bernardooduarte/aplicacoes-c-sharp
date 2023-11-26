using System;
using System.Globalization;

namespace ImpostodeRenda {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira o salário:");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calculo_taxa;

            if (salario <= 2000.00) {
                calculo_taxa = 0.00;
            }
            else if (salario <= 3000.00) {
                calculo_taxa = (salario - 2000.00) * 0.08;
            }
            else if (salario <= 4500.00) {
                calculo_taxa = (salario - 3000.00) * 0.18 + 1000.00 * 0.08;
            }
            else {
                calculo_taxa = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
            }

            if (calculo_taxa == 0.00) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine($"R$ {calculo_taxa.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}