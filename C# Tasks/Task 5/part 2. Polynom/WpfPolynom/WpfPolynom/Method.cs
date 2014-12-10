using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPolynom
{
	public class Method
	{
		public static string Show(string inputString1, string inputString2)
		{
			try
			{
				Polynom.Polynom p1 = new Polynom.Polynom(Polynom.Processing.Parse(inputString1));
				Polynom.Polynom p2 = new Polynom.Polynom(Polynom.Processing.Parse(inputString2));
				return "p1: " + p1.ToString() + "   p2: " + p2.ToString();
			}
			catch (ArgumentException myEx)
			{
				return myEx.Message;
			}
		}
		public static string Equal(string inputString1, string inputString2, bool choice)
		{
			try
			{
				Polynom.Polynom p1 = new Polynom.Polynom(Polynom.Processing.Parse(inputString1));
				Polynom.Polynom p2 = new Polynom.Polynom(Polynom.Processing.Parse(inputString2));
				return choice == true ? (p1 == p2).ToString() : (p1 != p2).ToString();
			}
			catch (ArgumentException myEx)
			{
				return myEx.Message;
			}
		}
		public static string Count(string inputString1, string inputString2, double count)
		{
			try
			{
				Polynom.Polynom p1 = new Polynom.Polynom(Polynom.Processing.Parse(inputString1));
				Polynom.Polynom p2 = new Polynom.Polynom(Polynom.Processing.Parse(inputString2));
				return "p1= " + p1.GetValue(count) + "   p2= " + p2.GetValue(count);
			}
			catch (ArgumentException myEx)
			{
				return myEx.Message;
			}
		}
		
	}
}
