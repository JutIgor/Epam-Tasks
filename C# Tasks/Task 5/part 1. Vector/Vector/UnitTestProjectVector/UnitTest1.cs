using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vector;

namespace UnitTestProjectVector
{
	[TestClass]
	public class UnitTest1
	{
		[ExpectedException(typeof(ArgumentException))]
		[TestMethod]
		public void TestCreateVectorException()
		{
			Vector.Vector v1 = new Vector.Vector(1);
		}
		[TestMethod]
		public void TestCreateVector()
		{
			Vector.Vector v1 = new Vector.Vector(1, 2, 4.0);
			Assert.IsNotNull(v1);
		}
		[TestMethod]
		public void TestAdditionVectors()
		{
			Vector.Vector v1 = new Vector.Vector(1, 2, 4.0);
			Vector.Vector v2 = new Vector.Vector(4, 2.7, -1);
			Assert.IsNotNull(v1 + v2);
		}
		[ExpectedException(typeof(ArgumentException))]
		[TestMethod]
		public void TestSubtractionVectors()
		{
			Vector.Vector v1 = new Vector.Vector(8, 3.0);
			Vector.Vector v2 = new Vector.Vector(11, 9, -14);
			Vector.Vector v3 = v1 - v2;
		}
		[TestMethod]
		public void TestMultiplicationVectors()
		{
			Vector.Vector v1 = new Vector.Vector(8, 3.0, 12);
			Vector.Vector v2 = new Vector.Vector(11, 9, -14);
			double result = v1 * v2;
			Assert.AreEqual(result, -53.0);
		}
		[TestMethod]
		public void TestLengthVector()
		{
			Vector.Vector v1 = new Vector.Vector(4, 8, 2);
			Assert.IsTrue(Math.Abs(v1.Length() - 9.165) < 0.01);
		}
		[TestMethod]
		public void TestAngle()
		{
			Vector.Vector v1 = new Vector.Vector(4, 8, 2);
			Vector.Vector v2 = new Vector.Vector(8, 1, 3.0);
			Assert.IsTrue(Math.Abs(Vector.Vector.Angle(v1, v2) - 0.5834) < 0.01);
		}
	}
}
