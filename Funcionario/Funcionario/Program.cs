﻿using System;
using System.Globalization;

namespace Funcionario {
    class Program {
        static void Main(string[] args) {

            Funcionario dados = new Funcionario();

            Console.Write("Nome: ");
            dados.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            dados.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            dados.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + dados);

            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + dados);
        }
    }
}