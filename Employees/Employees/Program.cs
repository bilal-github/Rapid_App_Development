using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Bilal";
            employee1.Role = "Software Developer";
            employee1.Salary = 1000000m;

            Console.WriteLine(employee1);

            Employee employee2 = new Employee("Janitor", "Bob", 30000m);
            Console.WriteLine(employee2);



            Console.ReadKey();

        }
    }
}
