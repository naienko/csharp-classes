using System;

namespace classes
{
    public class Employee
    {
        private string _firstname;
		
		private string _lastname;
		public string Title { get; set; }
		
		private DateTime _startDate;

		public Employee( string fullname ) {
			string [] names = fullname.Split(" ");
			_firstname = names[0];
			_lastname = names[1];
		}
		public Employee Hire() {
			_startDate = DateTime.Now;
			return this;
		}

		public override string ToString() {
			return $@"{_firstname} {_lastname}, {Title}
Hired on: {_startDate}
";
		}
    }
}
