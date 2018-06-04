using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class Manager : Employee
	{
		public decimal PurchaseAuth { get; set; }

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"Manger: PurchaseAuth {PurchaseAuth}");
		}

	}
}
