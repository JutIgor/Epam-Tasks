using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using NOD;

namespace UnitTestProject
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestEuklid1()
		{
			int a = 525, b = 30, etalon = 15;
			Stopwatch Time = new Stopwatch();
			Assert.AreEqual(NODAlgorithms.Euklid(out Time, a, b), etalon);
		}
		[TestMethod]
		public void TestEuklid2()
		{
			int a = 30, b = 30, etalon = 30;
			Stopwatch Time = new Stopwatch();
			Assert.AreEqual(NODAlgorithms.Euklid(out Time, a, b), etalon);
		}
		[TestMethod]
		public void TestEuklid3()
		{
			int[] input = { 40, 50, 60, 75, 80, 125 };
			int etalon = 5;
			Stopwatch Time = new Stopwatch();
			Assert.AreEqual(NODAlgorithms.Euklid(out Time, input), etalon);
		}
		[TestMethod]
		public void TestStein1()
		{
			int a = 525, b = 30, etalon = 15;
			Stopwatch Time = new Stopwatch();
			Assert.AreEqual(NODAlgorithms.Stein(out Time, a, b), etalon);
		}
		[TestMethod]
		public void TestMethodNOD()
		{
			string input = "312   444  ';;; 812", etalon = "4";
			Stopwatch Time = new Stopwatch();
			Assert.AreEqual(ProcInput.MethodNOD(out Time, input, true), etalon);
		}
	}
}
