using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Convert;

namespace UnitTestProject
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			int number = 22;
			string sample = "10110";
			string result = IntToBinString.Convert(number);
			Assert.AreEqual(sample, result);
		}
	}
}
