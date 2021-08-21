﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAngularApp.Models
{
    public class Employee
    {
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public int Age { get; set; }

		[Required]
		public string Designation { get; set; }

		[Required]
		public int MobileNumber { get; set; }
	}
}
