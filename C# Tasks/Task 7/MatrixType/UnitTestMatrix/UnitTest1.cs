using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixType;

namespace UnitTestMatrix
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Testcreate()
		{
			Matrix m = new Matrix(3, 4);
			Assert.IsNotNull(m);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestCreate2()
		{
			double[,] array = null;
			Matrix m = new Matrix(array);
		}
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestInverse()
		{
			double[,] array = { { 4, 1 }, { 2, -2 }, { 4, 8 } };
			Matrix m = new Matrix(array);
			m.Inverse();
		}
		[TestMethod]
		public void TestAddition()
		{
			double[,] array = { { 4, 1 }, { 2, -2 } };
			double[,] array2 = { { 1, 2 }, { 2, 3 } };
			double[,] expected = { { 5, 3 }, { 4, 1 } };
			Matrix m = new Matrix(array);
			Matrix m2 = new Matrix(array2);
			Matrix m3 = m + m2;
			CollectionAssert.AreEqual(expected, m3.Array);
		}
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestSubtraction()
		{
			double[,] array = { { 4, 1 }, { 2, -2 } };
			double[,] array2 = { { 1, 2, 3 }, { 2, 3, 4 }, { 1, 1, 3 } };
			Matrix m = new Matrix(array);
			Matrix m2 = new Matrix(array2);
			Matrix m3 = m * m2;
		}
		[TestMethod]
		public void TestMultiplication()
		{
			double[,] array = { { 1, 2 }, { 3, 4 } };
			double[,] array2 = { { 1, 2 }, { 3, 4 } };
			double[,] expected = { { 7, 10 }, { 15, 22 } };
			Matrix m = new Matrix(array);
			Matrix m2 = new Matrix(array2);
			Matrix m3 = m * m2;
			CollectionAssert.AreEqual(expected, m3.Array);
		}
		[TestMethod]
		public void TestToString()
		{
			double[,] array = { { 2, 2 }, { 3, 2 } };
			string expected = "2\t2\t\n3\t2\t\n";
			Matrix m = new Matrix(array);
			Assert.AreEqual(expected, m.ToString());
		}
	}
}
