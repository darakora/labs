using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            //CircleInTrapezoid circleInTrapezoid = new CircleInTrapezoid(1, 1, 2, 2, 3);
            //Console.WriteLine(circleInTrapezoid.ToString());
            //Console.WriteLine(circleInTrapezoid.TrapezoidalSquare());
            //Console.WriteLine(circleInTrapezoid.CircleSquare());
            //circleInTrapezoid.CheckForExistence();

            //CVector<int> v = new CVector<int>(new List<int> { 1, 2 });
            //CVector<int> r = v++;
            //r.Print();

            /*List<Employee> employees = new List<Employee>()
            {
                new Employee("Lox", 19, "Petrov", 32.2),
                new Employee("neLox", 32, "Lalka", 233)
            };

            Employees employees1 = new Employees(employees);
            employees1.PrintList();*/

            string line = "M(m(6,5),M(8,2))";
            int pos = 0;
            Formula frm = Lab17_1.Parse(line, ref pos);

            int M = Lab17_1.Calc(frm); // M = 3
            Console.WriteLine(M);
            Console.ReadKey();
        }
    }
}
