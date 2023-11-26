using System;
using System.Globalization;

namespace PlanoCartesiano {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira as coordenadas X e Y do Ponto:");
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0].ToString(CultureInfo.InvariantCulture));
            double y = double.Parse(valores[1].ToString(CultureInfo.InvariantCulture));

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0) {
                Console.WriteLine("Eixo X");
            }
            else if (y == 0.0) {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }
        }
    }
}
