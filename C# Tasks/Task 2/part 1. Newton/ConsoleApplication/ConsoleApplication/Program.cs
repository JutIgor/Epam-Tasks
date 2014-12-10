using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newton;

namespace ConsoleApplication
{
	class Program
	{
		static string StringExceptionRuntime = "Houston, we have a problem!";
		static void Main(string[] args)
		{
			try
			{
				string number, power, precision, choice;
				Console.WriteLine("Enter the number: ");
				number = Console.ReadLine();
				Console.WriteLine("Enter the power: ");
				power = Console.ReadLine();
				Console.WriteLine("Enter the precision: ");
				precision = Console.ReadLine();
				Console.WriteLine("Compare with Math.pow? (y/n)");
				choice = Console.ReadLine();
				List<double> root = new List<double>();
				root = Input.Method(number, power, precision, choice);
				Console.WriteLine("Root (Newton): ");
				Console.WriteLine(root[0]);
				if(root.Count == 2)
				{
					Console.WriteLine("Root (Math.Pow): ");
					Console.WriteLine(root[1]);
				}
				Console.ReadKey();
			}
			catch(ArgumentException MyException)
			{
				Console.WriteLine(MyException.Message);
				Console.ReadKey();
			}
			catch (Exception)
			{
				Console.WriteLine(StringExceptionRuntime);
				Console.ReadKey();
			}
		}
	}
}
