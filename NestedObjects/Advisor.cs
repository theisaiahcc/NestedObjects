using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
	/// <summary>
	/// represents college advisor
	/// </summary>
	internal class Advisor
	{
		/// <summary>
		/// Advisors full name
		/// </summary>
		public string FullName { get; set; }
		/// <summary>
		/// Advisors contact email
		/// </summary>
		public string Email { get; set; }
		/// <summary>
		/// Advisors building and room information
		/// </summary>
		public string OfficeLocation { get; set; }
	}
}
