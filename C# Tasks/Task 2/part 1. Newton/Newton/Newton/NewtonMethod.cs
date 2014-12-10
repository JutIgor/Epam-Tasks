using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton
{
    public class NewtonMethod
    {
		private static string Message = "Bad input!";
		/// <summary>
		/// Function NewtonsMethod calculate root of Number degree of Power with accuracy Precision
		/// </summary>
		/// <param name="Number"></param>
		/// <param name="Power"></param>
		/// <param name="Precision"></param>
		/// <returns></returns>
		public static double NewtonsMethod (double Number, int Power, double Precision = 0.01)
		{
			if(Power == 0)
			{
				return 1.0;
			}
			double x = 1.0, xK;
			do
			{
				xK = x;
				x = (xK * (Power - 1) + Number / Math.Pow(xK, Power - 1)) / Power;
			} while (Math.Abs(x - xK) > Precision);
			return x;
		}
		/// <summary>
		/// Function MathPowMethod calculate root of Number degree of Power
		/// </summary>
		/// <param name="Number"></param>
		/// <param name="Power"></param>
		/// <returns></returns>
		public static double MathPowMethod (double Number, int Power)
		{
			return Math.Pow(Number, 1.0 / Power);
		}
    }
}
