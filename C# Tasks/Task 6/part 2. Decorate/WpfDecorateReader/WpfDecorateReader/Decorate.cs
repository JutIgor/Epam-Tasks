using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDecorateReader
{
	public class Decorate: MyReader 
	{
		private MyReader Reader;
		//private int Password = "656".GetHashCode(); // в ресурсы
		private int CurIndex;
		private int MaxIndex;
		
		public Decorate(string input)
		{
			if (Resource.Password != input)
			{
				throw new ArgumentException("Wrong Password!");
			}
			Reader = new MyReader(Resource.Path);
			MaxIndex = Reader.TextLength();
			CurIndex = 0;
		}
		public string ReadText(double pos)
		{
			int varIndex = (int)(pos * MaxIndex - CurIndex);
			if (varIndex < 0) return String.Empty;
			char[] result = Reader.Read(varIndex);
			StringBuilder outputString = new StringBuilder(result.Length);
			for (int i = 0; i < result.Length; i++)
			{
				outputString.Append(result[i]);
			}
			CurIndex += varIndex;
			return outputString.ToString();
		}
	}
}
