using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace Struct_pract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Someone";
            employee.Salary = 80_000;
            employee.Vacancy = Vacansiec.Clerk;
            employee.SetEmploymentDate(16, 12, 2001);

            Console.WriteLine(employee);
            Console.ReadLine();
        }
    }
}
