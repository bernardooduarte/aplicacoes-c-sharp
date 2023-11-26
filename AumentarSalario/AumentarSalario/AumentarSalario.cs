﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace AumentarSalario {
    class AumentarSalario {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public AumentarSalario(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage) {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString(CultureInfo.InvariantCulture);
        }
    }
}
