using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNotePad
{
	public class Decorate
	{
		private Reader reader;
		private int CurIndex;
		private int MaxIndex;

		public Decorate()
		{
			reader = new Reader();
			MaxIndex = reader.TextLength();
			CurIndex = 0;
		}
		public string ReadText(double pos)
		{
			int varIndex = (int)(pos * MaxIndex - CurIndex);
			if (varIndex < 0) return String.Empty;
			char[] result = reader.Read(varIndex, CurIndex);
			StringBuilder outputString = new StringBuilder(result.Length);
			for (int i = 0; i < result.Length; i++)
			{
				outputString.Append(result[i]);
			}
			CurIndex += varIndex;
			return outputString.ToString();
		}

		public void Save(List<TextChanges> Changes)
		{
			reader.Write(Changes, MaxIndex);
		}
	}
}
