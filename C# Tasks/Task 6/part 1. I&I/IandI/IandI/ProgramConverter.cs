using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IandI
{
	public class ProgramConverter: IConvertible
	{
		public string ConvertToCSharp(string inputString)
		{
			return "Converted to C#!";
		}

		public string ConvertToVB(string inputString)
		{
			return "Converted to VB!";
		}
	}
}
