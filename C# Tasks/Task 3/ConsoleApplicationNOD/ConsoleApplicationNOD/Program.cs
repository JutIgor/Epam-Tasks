using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using NOD;

namespace ConsoleApplicationNOD
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{

				Stopwatch Time = new Stopwatch();
				string input, choice;
				Console.WriteLine("Enter the positive numbers:");
				input = Console.ReadLine();
				Console.WriteLine("Choose the Method (e/s):");
				choice = Console.ReadLine();
				Console.WriteLine("NOD:");
				if (choice == "e")
				{
					Console.WriteLine(ProcInput.MethodNOD(out Time, input, true));
				}
				else
				{
					Console.WriteLine(ProcInput.MethodNOD(out Time, input, false));
				}
				Console.WriteLine("Time: {0}", Time.ElapsedTicks);
				Console.ReadKey();
			}
			catch (ArgumentException MyEx)
			{
				Console.WriteLine(MyEx.Message);
			}
		}
	}
}
