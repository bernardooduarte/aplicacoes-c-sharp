using AumentarSalario2;
using System;
using System.Globalization;


namespace AumentarSalario {
    class Program {
        static void Main(string[] args) {

            Console.Write("Insira a quantidade de funcionários: ");
            int qtd = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= qtd; i++) {

                Console.WriteLine("Funcionário #" + i + ":");
                Console.Write("Insira o id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Insira o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Insira o salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, nome, salario));

                Console.WriteLine();
            }

            Console.Write("Insira o id do funcionário que vai ter o salário aumentado: ");
            int iddesej = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == iddesej);

            if (func != null) {
                Console.Write("Insira a porcentagem: ");
                double porcen = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.Aumento(porcen);
            }
            else {
                Console.WriteLine("Esse id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizados:");
            foreach (Funcionario obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}