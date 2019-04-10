using System;
using System.Collections.Generic;
using System.Text;

namespace classes
{
	public class Company {
		public string Name { get; }

		public int CreatedOn { get; }

		public List<Employee> Employees { get; private set; } = new List<Employee>();

		public Company (string name, int year) { 
			Name = name;
			CreatedOn = year;
		}

		public void HireEmployees (List<Employee> employees) {
			Employees.AddRange(employees);
		}

		public void HireEmployees (Employee employees) {
			Employees.Add(employees);
		}

		public override string ToString() {
			StringBuilder output = new StringBuilder($@"
{Name.ToUpper()}
Year Founded: {CreatedOn}

Employees:
");
				Employees.ForEach(e => output.Append($"{e}\n"));
				return output.ToString();
			}
    }
}
