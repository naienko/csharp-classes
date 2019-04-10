using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main()
        {
        // Create an instance of a company. Name it whatever you like.
        Company corporation = new Company("Pawprint Productions", 2002);

        // Create three employees
        Employee CEO = new Employee("Summer Rainault") {
            Title = "CEO"
        };
        CEO.Hire();

        Employee CFO = new Employee("Kieran Dubhglas") {
            Title = "CFO"
        };
        CFO.Hire();

        Employee CIO = new Employee("Barry Allen") {
            Title = "CIO"
        };
        CIO.Hire();

        // Assign the employees to the company
        corporation.HireEmployees(new List<Employee> {
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
