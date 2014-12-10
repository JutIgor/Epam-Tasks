using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Vector
{
	public class Process
	{
		public static double[] Parse(string input)
		{
			List<double> inputList = new List<double>();
			RegexOptions option = RegexOptions.None;
			Regex pattern = new Regex(@"(-)?[0-9]+(\.[0-9]+)?", option);
			MatchCollection matches = pattern.Matches(input);
			if (matches.Count < 2)
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

		public static string Show(Vector v1)
		{
			StringBuilder strV1 = new StringBuilder();
			strV1.Append("(");
			for (int i = 0; i < v1.Power; i++)
			{
				strV1.Append(v1[i].ToString());
				strV1.Append(",");
			}
			strV1.Remove(strV1.Length-1, 1);
			strV1.Append(")");
			return strV1.ToString();
		}
	}
}
