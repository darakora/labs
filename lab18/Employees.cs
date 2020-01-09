using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Surname { get; set; }
        public double Sullary { get; set; }

        public Employee()
        {

        }
        public Employee(string Name, int Age, string Surname, double Sullary)
        {
            this.Name = Name;
            this.Age = Age;
            this.Surname = Surname;
            this.Sullary = Sullary;
        }

        public override string ToString()
        {
            return Name + "\n" + Surname + "\n" + Age + "\n" + Sullary + "\n";
        }
    }
    class Employees
    {
        public List<Employee> employees;
        public Employees()
        {

        }

        public Employees(List<Employee> employees)
        {
            this.employees = employees;
        }

        public void PrintList()
        {
            foreach (Employee i in employees)
            {
                Console.WriteLine(i);
            }
        }


    }
}
