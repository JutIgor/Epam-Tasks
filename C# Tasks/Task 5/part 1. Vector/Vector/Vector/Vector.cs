using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    public class Vector
    {
		private static string exceptionValue = "Bad value!";
		private static string exceptionInput = "Bad input!";
		private static string exceptionLength = "Vectors have different length!";
		private static string exceptionIndex = "Index out of the range!";
		private static string exceptionNull = "Object have NULL reference!";
		private double[] Coordinates;
		private int power;
		public static int Counter;
		public int Power
		{
			get { return power; }
		}
		public double this[int i]
		{
			get
			{//
				if(i < 0 && i > Coordinates.Length - 1)
				{
					throw new ArgumentException(exceptionIndex);
				}
				return Coordinates[i];
			}
			set
			{
				if (i < 0 && i > Coordinates.Length - 1)
				{
					throw new ArgumentException(exceptionIndex);
				}
				Coordinates[i] = value;
			}
		}
		public Vector (params double[] inputArray)
		{//
			if (inputArray == null)
			{
				throw new ArgumentException(exceptionNull);
			}
			else if (inputArray.Length < 2)
			{
				throw new ArgumentException(exceptionInput);
			}
			Coordinates = (double[])inputArray.Clone();
			power = Coordinates.Length;
			Counter++;
		}
		public static Vector operator+ (Vector v1, Vector v2)
		{//
			v1.CheckNullRef();
			v2.CheckNullRef();
			if(v1.Coordinates.Length != v2.Coordinates.Length)
			{
				throw new ArgumentException(exceptionLength);
			}
			double[] resultArray = new double[v1.Coordinates.Length];
			for (int i = 0; i < v1.Coordinates.Length; i++)
			{
				resultArray[i] = v1[i] + v2[i];
			}
			return new Vector(resultArray);
		}
		public static Vector operator- (Vector v1, Vector v2)
		{//
			v1.CheckNullRef();
			v2.CheckNullRef();
			double[] negativeV2 = new double[v2.Coordinates.Length];
			for(int i = 0; i < v2.Coordinates.Length; i++)
			{
				negativeV2[i] = -v2[i];
			}
			Vector temp = new Vector(negativeV2);
			return v1 + temp;
		}
		public static double operator* (Vector v1, Vector v2)
		{
			v1.CheckNullRef();
			v2.CheckNullRef();
			if (v1.Coordinates.Length != v2.Coordinates.Length)
			{
				throw new ArgumentException(exceptionLength);
			}
			double result = 0;
			for (int i = 0; i < v1.Coordinates.Length; i++)
			{
				result += v1[i] * v2[i];
			}
			return result;
		}
		public double Length()
		{
			this.CheckNullRef();
			double result = 0;
			for (int i = 0; i < this.Coordinates.Length; i++)
			{
				result += Math.Pow(this[i], 2.0);
			}
			return Math.Round(Math.Pow(result, 1.0 / 2.0), 4);
		}
		public static double Angle (Vector v1, Vector v2)
		{
			v1.CheckNullRef();
			v2.CheckNullRef();
			return Math.Round((v1 * v2) / (v1.Length() * v2.Length()), 4);
		}

		private bool CheckNullRef()
		{
			if(this == null)
			{
				throw new ArgumentException(exceptionNull);
			}
			return true;
		}
    }
}
