using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class Administrator : Employee
	{
		public Manager AssignedTo { get; set; }

		public override void Print()
		{
			Console.WriteLine($"Administrator: assigned to {AssignedTo.Name}");
		}

	}
}
