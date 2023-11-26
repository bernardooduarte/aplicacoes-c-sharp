using System;
using System.Globalization;

namespace calculasalario {
    class Program {
        static void Main(string[] args) {
            int id, hours;
            double valph, salary;

            id = int.Parse(Console.ReadLine());
            hours = int.Parse(Console.ReadLine());
            valph = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salary = valph * hours;

            Console.WriteLine($"NUMBER = {id}");
            Console.WriteLine($"SALARY = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
