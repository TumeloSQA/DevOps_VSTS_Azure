using System;
using System.ComponentModel.DataAnnotations;

namespace DevOps_VSTS_Azure.Models
{
	public class Employee
	{

		public int ID { get; set; }

		[Required(ErrorMessage = "This is a required field")]
		public string Name { get; set; }

		[Required(ErrorMessage = "This is a required field")]
		public string Address { get; set; }

		[Required(ErrorMessage = "This is a required field")]
		public int Age { get; set; }
	}
}

