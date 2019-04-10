using System;

namespace classes
{
    class Program
    {
        static void Main()
        {
        // Create an instance of a company. Name it whatever you like.
        Company corporation = new Company("Pawprint Productions", 2002);

        // Create three employees
        Employee CEO = new Employee("Summer Rainault");
        Employee.Title = "CEO";
        Employee.Hire();

        Employee CFO = new Employee("Kieran Dubhglas");
        Employee.Title = "CFO";
        Employee.Hire();

        Employee CIO = new Employee("Barry Allen");
        Employee.Title = "CIO";
        Employee.Hire();

        // Assign the employees to the company
        Company.HireEmployees(new List<Employee> {
            CEO, CFO, CIO
        });

        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */

        Console.WriteLine(corporation);
        }
    }
}
