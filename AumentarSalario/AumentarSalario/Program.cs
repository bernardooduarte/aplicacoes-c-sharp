using System;
using System.Globalization;
using System.Collections.Generic;

namespace AumentarSalario {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registered? ");
            int qtd = int.Parse(Console.ReadLine());

            List<AumentarSalario> list = new List<AumentarSalario>();

            for (int i = 1; i <= qtd; i++) {
                Console.WriteLine("Emplyoee #" + i + ":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new AumentarSalario(id, name, salary));

                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchid = int.Parse(Console.ReadLine());

            AumentarSalario aus = list.Find(x => x.Id == searchid);

            if (aus != null) {
                Console.Write("Enter the percentage: ");
                double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aus.increaseSalary(perc);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
           
            Console.WriteLine("Updated list of employees:");

            foreach (AumentarSalario obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
