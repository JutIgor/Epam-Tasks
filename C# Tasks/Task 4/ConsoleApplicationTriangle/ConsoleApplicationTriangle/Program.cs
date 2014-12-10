using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle;

namespace ConsoleApplicationTriangle
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Enter side of triangle or coordinates of points:");
				Triangle.Triangle obj; 
				double[] result = ProcInput.Method(Console.ReadLine());
				if(result.Length == 3)
				{
					obj = new Triangle.Triangle(result[0], result[1], result[2]);
				}
				else
				{
					obj = new Triangle.Triangle(result);
				}
				Console.WriteLine("P = {0}", obj.Perimeter());
				Console.WriteLine("S = {0}", obj.Square());
				Console.ReadKey();
			}
			catch (ArgumentException MyEx)
			{
				Console.WriteLine(MyEx.Message);
				Console.ReadKey();
			}
		}
	}
}
