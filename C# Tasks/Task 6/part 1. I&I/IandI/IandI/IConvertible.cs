using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IandI
{
    public interface IConvertible
    {
		string ConvertToCSharp(string inputString);
		string ConvertToVB(string inputString);
    }
}
