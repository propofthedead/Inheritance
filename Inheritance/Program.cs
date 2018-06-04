using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee e1 = new Employee();
			e1.Name = "e1";
			e1.Position = "flunky";
			e1.Salary = 5999;
			e1.VacationDays = 3;
			e1.Print();
			Manager m1 = new Manager();
			m1.Name = "M1";
			m1.Position = "Supervisor";
			m1.Salary = 6000;
			m1.VacationDays = 10;
			m1.PurchaseAuth = 10.99M;
			m1.Print();


			e1.Manager = m1;
			List<Employee> employees = new List<Employee>();
			employees.Add(e1);
			employees.Add(m1);

			foreach (Employee em in employees) {
				Console.WriteLine($"Employee: Name {em.Name} salaray {em.Salary}");
			}
		}
	}
}
