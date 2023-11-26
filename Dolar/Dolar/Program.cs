using System;
using System.Globalization;

namespace Dolar {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtddolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.CalcularValorTotal(cotacao, qtddolar);

            Console.WriteLine();
            Console.WriteLine("Valor a ser pago em reais = "
                + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}