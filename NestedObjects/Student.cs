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
		/// <summary>
		/// First legal name
		/// </summary>
		public string FirstName { get; set; }
		/// <summary>
		/// Last legal name
		/// </summary>
		public string LastName { get; set; }
		/// <summary>
		/// Date of birth
		/// </summary>
		public DateOnly DateOfBirth { get; set; }
		/// <summary>
		/// School email address
		/// </summary>
		public string SchoolEmail { get; set; }
		/// <summary>
		/// Preferred phone number
		/// </summary>
		public string Phone { get; set; }
		/// <summary>
		/// Advisor assigned to student
		/// </summary>
		public Advisor Advisor { get; set; }
	}
}
