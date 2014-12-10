using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractFloat
{
    public class FloatList
    {
		public static List<string> Extract(string Input)
		{
			List<string> FloatList = new List<string>();
			int Cur = 0;
			string BlankX = "X = ", BlankY = "Y = ";
			string EmptyInput = "Input string is Empty!";
			try
			{
				if (Input == "")
				{
					throw new ArgumentException(EmptyInput);
				}
			}
			catch (ArgumentException My_Exception)
			{
				FloatList.Add(My_Exception.Message);
				return FloatList;
			}
			RegexOptions Option = RegexOptions.Multiline;
			Regex Pattern = new Regex(@"[0-9]+\.[0-9]+", Option);
			MatchCollection Matches = Pattern.Matches(Input);
			foreach (Match Mat in Matches)
			{
				FloatList.Add(Mat.Value);
				FloatList[Cur] = FloatList[Cur].Replace(".", ",");
				if(Cur%2==0)
				{
					FloatList[Cur] = BlankX + FloatList[Cur];
				}
				else
				{
					FloatList[Cur] = BlankY + FloatList[Cur];
				}
				Cur++;
			}
			return FloatList;
		}
    }
}
