using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace UnitTestTriangle
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethodExist()
		{
			//string input = "3.0 5 pppp4";
			double[] input = { 3, 5.0, 4 };
			Triangle.Triangle obj = new Triangle.Triangle(input[0], input[1], input[2]);
			Assert.IsNotNull(obj);
		}
		[ExpectedException(typeof(ArgumentException))]
		[TestMethod]
		public void TestMethodNull()
		{
			//string input = "36.0 -25 17 88 33 -9";
			//string input = "36.0 -25 36 -25.0 33 -9";
			double[] input = { 36.0, -25, 36, -25.0, 33, -9 };
			Triangle.Triangle obj = new Triangle.Triangle(input);
		}
		[TestMethod]
		public void TestMethodP()
		{
			//string input = "3.0 5 pppp4";
			double[] input = { 3.0, 5, 4 };
			Triangle.Triangle obj = new Triangle.Triangle(input[0], input[1], input[2]);
			Assert.AreEqual(obj.Perimeter(), 12.0);
		}
		[TestMethod]
		public void TestMethodS()
		{
			//string input = "3.0 5 pppp4";
			double[] input = { 3.0, 5, 4 };
			Triangle.Triangle obj = new Triangle.Triangle(input[0], input[1], input[2]);
			Assert.AreEqual(obj.Square() , 6.0);
		}
	}
}
