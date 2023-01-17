using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
	/// <summary>
	/// Represents individual college student
	/// </summary>
	internal class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateOnly DateOfBirth { get; set; }
		public string SchoolEmail { get; set; }
		public string Phone { get; set; }
		public Advisor Advisor { get; set; }
	}
}
