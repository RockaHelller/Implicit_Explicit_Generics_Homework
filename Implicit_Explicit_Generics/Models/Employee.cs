using System;
using System.Collections.Generic;
using System.Text;

namespace Implicit_Explicit_Generics.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public double Salary { get; set; }

        public Employee(DateTime birthday, double salary)
        {
            Birthday = birthday;
            Salary = salary;
        }

        public bool CheckInfo(DateTime start, DateTime end, int a = 2000)
        {
            if ((Birthday > start && Birthday < end) && Salary > a)
            {
                return true;
            }
            return false;
        }
    }
}
