using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polynom;

namespace UnitTestPolynom
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestCreatePolynom()
		{
			double[] param = { 2.33, 11, 20.5 };
			Assert.IsNotNull(new Polynom.Polynom(param));
		}
		[ExpectedException(typeof(ArgumentException))]
		[TestMethod]
		public void TestExcCrPolynom()
		{
			double[] param = {};
			Assert.IsNotNull(new Polynom.Polynom(param));
		}
		[TestMethod]
		public void TestEqualPolynoms()
		{
			Polynom.Polynom p1 = new Polynom.Polynom(4, 3, 9.0);
			Polynom.Polynom p2 = new Polynom.Polynom(7, 4, 1);
			Assert.IsFalse(p1 == p2);
		}
		[TestMethod]
		public void TestNotEqualPolynoms()
		{
			Polynom.Polynom p1 = new Polynom.Polynom(4, 3, 9.0);
			Polynom.Polynom p2 = new Polynom.Polynom(7, 4, 1);
			Assert.IsTrue(p1 != p2);
		}
		[TestMethod]
		public void TestCountPolynom()
		{
			Polynom.Polynom p1 = new Polynom.Polynom(1, 0, 3, 4.0);
			Assert.AreEqual(p1.GetValue(5), 720);
		}

		[ExpectedException(typeof(ArgumentException))]
		[TestMethod]
		public void TestExcCreate()
		{
			Polynom.Polynom p1 = new Polynom.Polynom();
			Polynom.Polynom p2 = new Polynom.Polynom(2, 3);
		}

		[TestMethod]
		public void TestExcEqual()
		{
			Polynom.Polynom p1 = null;
			Polynom.Polynom p2 = new Polynom.Polynom(2, 3);
			Assert.IsFalse(p1 == p2);
		}
	}
}
