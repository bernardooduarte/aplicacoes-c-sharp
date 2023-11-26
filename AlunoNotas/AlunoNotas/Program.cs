using System;
using System.Globalization;

namespace AlunoNotas {
    class Program {
        static void Main(string[] args) {

            Aluno dados = new Aluno();

            Console.Write("Nome do Aluno: ");
            dados.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            dados.NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("NOTA FINAL = "
                + dados.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (dados.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                    + dados.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }

        }
    }
}
