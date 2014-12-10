using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convert;

namespace ConsoleApplication
{
	class Program
	{
		private static string ExcMessage = "Houston, we have a problem!";
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Enter the number:");
				Console.WriteLine(ProcessingInput.Method(Console.ReadLine()));
				Console.ReadKey();
			}
			catch (ArgumentException MyE)
			{
				Console.WriteLine(MyE.Message);
			}
			catch (Exception)
			{
				Console.WriteLine(ExcMessage);
			}
		}
	}
}
