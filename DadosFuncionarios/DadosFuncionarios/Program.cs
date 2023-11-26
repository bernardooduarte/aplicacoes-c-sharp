using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace DadosFuncionarios {
    class Program {
        static void Main(string[] args) {

            Funcionarios x = new Funcionarios();
            Funcionarios y = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (x.Salario + y.Salario) / 2.0;

            Console.WriteLine("Salário médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
