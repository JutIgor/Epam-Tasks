using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixType;

namespace ConsoleMatrix
{
	class Program
	{
		static void Main(string[] args)
		{
			double[,] firstArray = { { 5, 4.0 }, { 2, 3 } };
			double[,] secondArray = { { 13, 2 }, { 0, -3 } };
			Matrix matrix1 = new Matrix(firstArray);
			Matrix matrix2 = new Matrix(secondArray);
			Matrix matrix3 = matrix1 + matrix2;
			Console.WriteLine(matrix3.ToString());
			Console.WriteLine();
			matrix3 = matrix1 - matrix2;
			Console.WriteLine(matrix3.ToString());
			Console.WriteLine();
			matrix3 = matrix1 * matrix2;
			Console.WriteLine(matrix3.ToString());
			Console.WriteLine();
			matrix3.CompareTo(matrix2);
			Console.WriteLine(matrix3.ToString());
			Console.WriteLine();
			Console.WriteLine(matrix3.Inverse().ToString());
			Console.ReadKey();
		}
	}
}
