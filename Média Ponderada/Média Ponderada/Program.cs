using System;
using System.Globalization;

namespace MediaPonderada {
    class Program {
        static void Main(string[] args) {

            Console.Write("Insira a quantidade de testes: ");
            int qtd_testes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd_testes; i++) {
                Console.Write($"Valores: ");
                string[] valores = Console.ReadLine().Split(' ');
                double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (A * 2.0 + B * 3.0 + C * 5.0) / 10.0;
                Console.WriteLine($"Média: {media.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}