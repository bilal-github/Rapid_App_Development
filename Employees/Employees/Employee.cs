using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Employee
    {
        private string role;
        private string name;
        private decimal salary;

        // public properties
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public decimal Salary
        {
            get { return salary; }
            set
            {
                salary = (value < 0) ? -value : value;
            }
        }

        public Employee() { } // default constructor
        public Employee(string r, string n, decimal s)
        {
            Role = r;
            Name = n;
            Salary = s;
        }

        public override string ToString()
        {
            return "Name: " + name + "\n    Role: " + role + "\n    Salary: " + salary.ToString("c") +"\n";
        }
    }
}
