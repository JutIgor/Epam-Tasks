using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
		private static string exceptionNullInput = "Incorrect input data!";
		private static string exceptionNullRef = "Object have NULL reference";
		private static string exceptionExistTriangle = "Triangle with specified parameters does not exist";
		private double sideA;
		private double sideB;
		private double sideC;

		public double SideA
		{
			get { return sideA; }
			set
			{
				if(CheckExistTriangle(value,sideB,sideC))
				{
					sideA = value;
				}
				else
				{
					throw new ArgumentException(exceptionExistTriangle);
				}
			}
		}
		public double SideB
		{
			get { return sideB; }
			set
			{
				if (CheckExistTriangle(sideA, value, sideC))
				{
					sideB = value;
				}
				else
				{
					throw new ArgumentException(exceptionExistTriangle);
				}
			}
		}
		public double SideC
		{
			get { return sideC; }
			set
			{
				if (CheckExistTriangle(sideA, sideB, value))
				{
					sideC = value;
				}
				else
				{
					throw new ArgumentException(exceptionExistTriangle);
				}
			}
		}
		//свойства с set существование
		// конструктор с точками
		// 
		public Triangle (double SA, double SB, double SC)
		{
			if(CheckExistTriangle(SA, SB, SC))
			{
				sideA = SA;
				sideB = SB;
				sideC = SC;
			}
			else
			{
				throw new ArgumentException(exceptionExistTriangle);
			}
		}

		public Triangle (double[] points)
		{
			if(points == null || points.Length != 6)
			{
				throw new ArgumentException(exceptionNullInput);
			}
			else if(CheckExistTriangle(Coordinates(points[0],points[1], points[2], points[3]),
				Coordinates(points[2], points[3], points[4], points[5]),
				Coordinates(points[0], points[1], points[4], points[5])))
			{
				sideA = Coordinates(points[0], points[1], points[2], points[3]);
				sideB = Coordinates(points[2], points[3], points[4], points[5]);
				sideC = Coordinates(points[0], points[1], points[4], points[5]);
			}
			else
			{
				throw new ArgumentException(exceptionExistTriangle);
			}
		}
		
		public double Perimeter()
		{
			if (this == null)
			{
				throw new ArgumentException(exceptionNullRef);
			}
			return SideA + SideB + SideC;
		}

		public double Square()
		{
			if (this == null)
			{
				throw new ArgumentException(exceptionNullRef);
			}
			double p = this.Perimeter() / 2;
			return Math.Pow(p * (p - SideA) * (p - SideB) * (p - SideC), 1.0 / 2.0);
		}
		private static bool CheckExistTriangle(double sideA, double sideB, double sideC)
		{
			if (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB && sideA > 0 && sideB >0 && sideC > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private static double Coordinates(double ax, double ay, double bx, double by)
		{
			return Math.Pow(Math.Pow(bx - ax, 2.0) + Math.Pow(by - ay, 2.0), 1 / 2.0);
		}
    }
}
