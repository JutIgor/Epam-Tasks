using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtractFloat;

namespace FloatConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			string Input = Console.ReadLine();
			List<string> Floats = new List<string>();
			Floats = FloatList.Extract(Input);
			foreach (string Element in Floats)
			{
				Console.WriteLine(Element);
			}
			Console.ReadKey();
		}
	}
}
