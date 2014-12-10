using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace NOD
{
	public class ProcInput
	{
		private static string ExcMessage = "Bad input! NOD need 2 or more numbers!";
		public static string MethodNOD (out Stopwatch Time, string Input, bool Choice)
		{
			List<int> listOfInt = new List<int>();
			RegexOptions Option = RegexOptions.None;
			Regex Pattern = new Regex(@"[0-9]+", Option);
			MatchCollection Matches = Pattern.Matches(Input);
			foreach (Match Sample in Matches)
			{
				listOfInt.Add(Convert.ToInt32(Sample.Value));
			}
			if(listOfInt.Count <= 1)
			{
				throw new ArgumentException(ExcMessage);
			}
			if(Choice)
			{
				return NODAlgorithms.Euklid(out Time, listOfInt.ToArray()).ToString();
			}
			else
			{
				return NODAlgorithms.Stein(out Time, listOfInt.ToArray()).ToString();
			}
		}
	}
}
