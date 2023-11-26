using System;
using System.Runtime.CompilerServices;

namespace DadosPessoas {
    class Program {
        static void Main(string[] args) {

            Pessoa p, s;
            p = new Pessoa();
            s = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            s.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            s.Idade = int.Parse(Console.ReadLine());

            if (p.Idade > s.Idade) {
                Console.WriteLine("Pessoa mais velha: " + p.Nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha: " + s.Nome);
            }

        }
    }
}
