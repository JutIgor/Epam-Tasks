using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IandI
{
	public interface ICodeChecker
	{
		bool CodeCheckSyntax(string code, string lang);
	}
}
