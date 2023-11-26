using System;
using System.Globalization;

namespace CalculadoraSimples {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);

            double adicao = Calculadora.Adicao(a, b);
            double subtracao = Calculadora.Subtracao(a, b);
            double multiplicacao = Calculadora.Multiplicacao(a, b);
            double divisao = Calculadora.Divisao(a, b);

            Console.WriteLine("Adição = "
                + adicao.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Subtração = "
                + subtracao.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Multiplicação = "
                + multiplicacao.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Divisão = "
                + divisao.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}