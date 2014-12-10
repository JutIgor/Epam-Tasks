using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynom
{
    public class Polynom
    {
		private const string exceptionValue = "Bad input!";
		private const string exceptionNull = "Null index!";
		private const string exceptionIndex = "Index out of the range!";
		private const string exceptionNullRef = "Object have NULL reference!";
		private double[] Coef;
		private int power;
		public static int Count;
		public double this[int i]
		{
			get
			{
				if (i < 0 && i > Coef.Length - 1)
				{
					throw new ArgumentException(exceptionIndex);
				}
				return Coef[i];
			}
			set
			{
				if(i < 0 && i > Coef.Length - 1)
				{
					throw new ArgumentException(exceptionIndex);
				}
				else if(value == null)
				{
					throw new ArgumentException(exceptionNull);
				}
				Coef[i] = value;
			}
		}
		public int Power
		{
			get { return power; }
		}
		public Polynom (params double[] inputArray)
		{
			if(inputArray == null)
			{
				throw new ArgumentException(exceptionNullRef);
			}
			else if(inputArray.Length == 0)
			{
				throw new ArgumentException(exceptionValue);
			}
			Coef = (double[])inputArray.Clone();
			power = Coef.Length;
			Count++;
		}
		public static bool operator==(Polynom p1, Polynom p2)
		{
			if(ReferenceEquals(p1, p2)) // msdn
			{
				return true;
			}
			if((object)p1 == null || (object)p2 == null)
			{
				return false;
			}
			if (p1.Coef.Length != p2.Coef.Length)
			{
				return false;
			}
			for (int i = 0; i < p1.Coef.Length; i++)
			{
				if(p1[i] != p2[i])
				{
					return false;
				}
			}
			return true;
		}
		public static bool operator!=(Polynom p1, Polynom p2)
		{
			if (p1.Coef == null && p2.Coef == null )
			{
				throw new ArgumentException(exceptionNullRef);
			}
			return !(p1 == p2);
		}
		public override string ToString()
		{
			this.CheckNullRef();
			StringBuilder pString = new StringBuilder();
			int len = this.Coef.Length;
			for (int i = 0; i < len; i++)
			{
				if (this[i] == 0) continue;
				pString.Append(this[i]);
				pString.Append("X^");
				pString.Append(len - i);
				pString.Append(" + ");
			}
			pString.Remove(pString.Length - 3, 3);
			return pString.ToString();
		}
		public double GetValue(double number)
		{
			this.CheckNullRef();
			double result = 0;
			int len = this.Coef.Length;
			for (int i = 0; i < len; i++)
			{
				if (this[i] == 0) continue;
				result += this[i] * Math.Pow(number, (double)len - i);
			}
			return result;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public bool Equals(Polynom obj)
		{
			obj.CheckNullRef();
			return this == obj;
		}
		private bool CheckNullRef()
		{
			if(ReferenceEquals(null, this))
			{
				throw new ArgumentException(exceptionNullRef);
			}
			return true;
		}
    }
}
