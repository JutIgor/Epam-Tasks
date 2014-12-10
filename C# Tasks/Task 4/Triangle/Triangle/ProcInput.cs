using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Triangle
{
	public class ProcInput
	{
		private static string exceptionBadnput = "Bad input!";
		public static double[] Method(string input)
		{
			if (input == null || input == "")
			{
				throw new ArgumentException(exceptionBadnput);
			}
			List<double> inputList = new List<double>();
			RegexOptions option = RegexOptions.None;
			Regex pattern = new Regex(@"(-)?[0-9]+(\.[0-9]+)?", option);
			MatchCollection matches = pattern.Matches(input);
			foreach (Match sample in matches)
			{
				inputList.Add(Convert.ToDouble(sample.Value.Replace('.', ',')));
			}
			double[] result = new double[inputList.Count];
			inputList.CopyTo(result);
			return result;
		}
	}
}
