﻿using System;
using System.Globalization;

namespace Banco {
    class Program {
        static void Main(string[] args) {

            ContaBancaria banco;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(),
                    CultureInfo.InvariantCulture);
                banco = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                banco = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(banco);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            banco.Deposito(quantia);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(banco);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            banco.Saque(quantia);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(banco);

        }
    }
}