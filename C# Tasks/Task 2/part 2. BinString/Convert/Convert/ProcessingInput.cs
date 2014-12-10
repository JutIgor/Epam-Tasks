using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
	public class ProcessingInput
	{
		private static string InputException = "Bad input!";
		public static string Method (string Input)
		{
			int number = System.Convert.ToInt32(Input);
			if(number <= 0)
			{
				throw new ArgumentException(InputException);
			}
			return IntToBinString.Convert(number);
		}
	}
}
