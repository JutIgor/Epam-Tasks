using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ExtractFloat;

namespace UnitTestFloat
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void ExtractValidString()
		{
			// arrange
			string Input = "1.8 8,7ppp9,7   9.0 0.9";
			List<string> FloatsExpected = new List<string>{ "X = 1,8", "Y = 9,0", "X = 0,9" };

			// act
			List<string> FloatsActual = FloatList.Extract(Input);

			//assert
			bool flag = true;
			if (FloatsExpected.Count != FloatsActual.Count)
				flag = false;
			else
			{
				for (int i = 0; i < FloatsExpected.Count; i++)
				{
					if (!FloatsExpected[i].Equals(FloatsActual[i]))
						flag = false;
				}
			}
			Assert.IsTrue(flag);
		}
	}
}
