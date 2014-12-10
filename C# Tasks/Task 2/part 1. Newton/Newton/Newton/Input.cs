using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton
{
	public class Input
	{
		static string StringExceptionInput = "Bad input!";
		/// <summary>
		/// Function Method process input data and call functions NewtonsMethod and MathPow (optional)
		/// </summary>
		/// <param name="Number"></param>
		/// <param name="Power"></param>
		/// <param name="Precision"></param>
		/// <param name="choice"></param>
		/// <returns></returns>
		public static List<double> Method(string Number, string Power, string Precision, string choice)
		{
			List<double> result = new List<double>();
			double num, prec;
			int pow;
			num = ConvertD(Number);
			pow = ConvertI(Power);
			prec = ConvertD(Precision);
			if (num == 0 || (num < 0 && pow % 2 == 0))
			{
				throw new ArgumentException(StringExceptionInput);
			}
			result.Add(NewtonMethod.NewtonsMethod(num, pow, prec));
			if (choice == "y")
			{
				result.Add(NewtonMethod.MathPowMethod(num, pow));
			}
			return result;
		}
		/// <summary>
		/// Function ConvertD convert string to double
		/// </summary>
		/// <param name="Input"></param>
		/// <returns></returns>
		private static double ConvertD(string Input)
		{
			return System.Convert.ToDouble(Input);
		}
		/// <summary>
		/// Function ConvertI convert string to int
		/// </summary>
		/// <param name="Input"></param>
		/// <returns></returns>
		private static int ConvertI(string Input)
		{
			return System.Convert.ToInt32(Input);
		}
	}
}
