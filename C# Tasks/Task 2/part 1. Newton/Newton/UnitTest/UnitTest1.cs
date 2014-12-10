using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newton;

namespace UnitTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestNewtonsMethod1()
		{
			double number = 25.5;
			int power = 3;
			double precision = 0.00000001;
			double Test = NewtonMethod.NewtonsMethod(number, power, precision);
			double Etalon = Math.Pow(number, 1.0 / power);
			Assert.IsTrue(Math.Abs(Etalon - Test) <= 0.01);
		}
	}
}
