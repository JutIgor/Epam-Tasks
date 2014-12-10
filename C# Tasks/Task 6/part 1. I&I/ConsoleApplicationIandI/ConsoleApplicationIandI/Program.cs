using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IandI;

namespace ConsoleApplicationIandI
{
	class Program
	{
		static void Main(string[] args)
		{
			var arrayPC = new ProgramConverter[2];
			arrayPC[0] = new ProgramConverter();
			arrayPC[1] = new ProgramHelper();
			for (int i = 0; i < arrayPC.Length; i++)
			{
				if(arrayPC[i] is ICodeChecker)
				{
					Console.WriteLine("{0} element realised ICodeChecker", i);
				}
			}
			Console.ReadKey();
		}
	}
}
