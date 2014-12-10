using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    public class IntToBinString
    {
		/// <summary>
		/// Function Convert returns string with binary view of input int Number
		/// </summary>
		/// <param name="Number"></param>
		/// <returns></returns>
		public static string Convert (int Number)
		{
			StringBuilder binString = new StringBuilder();
			do
			{
				binString.Append(Number % 2);
				Number /= 2;
			} while (Number != 0);
			return Reverse(binString.ToString());
		}
		/// <summary>
		/// Function Reverse returns reversive string Input
		/// </summary>
		/// <param name="Input"></param>
		/// <returns></returns>
		private static string Reverse(string Input)
		{
			char[] charArray = Input.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}
    }
}
