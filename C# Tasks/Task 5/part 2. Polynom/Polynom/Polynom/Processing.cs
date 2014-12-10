using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Polynom
{
	public class Processing
	{
		public static double[] Parse(string input)
		{
			List<double> inputList = new List<double>();
			RegexOptions option = RegexOptions.None;
			Regex pattern = new Regex(@"(-)?[0-9]+(\.[0-9]+)?", option);
			MatchCollection matches = pattern.Matches(input);
			if (matches.Count < 1)
			{
				throw new ArgumentException("Bad input!");
			}
			foreach (Match sample in matches)
			{
				inputList.Add(Convert.ToDouble(sample.Value.Replace('.', ',')));
			}
			double[] result = new double[inputList.Count];
			for (int i = 0; i < inputList.Count; i++)
			{
				result[i] = inputList[i];
			}
			return result;
		}

	}
}
