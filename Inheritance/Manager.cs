﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class Manager : Employee
	{
		public decimal PurchaseAuth { get; set; }

		public override string Print()
		{
			
			return ($"Manger: PurchaseAuth {PurchaseAuth}")+base.Print();
		}

	}
}
