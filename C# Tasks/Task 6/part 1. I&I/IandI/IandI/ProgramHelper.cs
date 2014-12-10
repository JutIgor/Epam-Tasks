using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IandI
{
	public class ProgramHelper: ProgramConverter, ICodeChecker
	{
		public bool CodeCheckSyntax(string code, string lang)
		{
			return code == lang;
		}
	}
}
