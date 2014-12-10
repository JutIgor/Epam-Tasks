using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixType
{
    public class Matrix: IComparable
    {
		private const string excBadInput = "Bad input!";
		private const string excBadIndex = "Index out of the range!";
		private const string excNotMatrix = "Object is not a matrix!";
		private const string excExistDeterm = "Determinant can't be calculated!";
		private const string excNullDeterm = "Dererminant = 0!";
		private const string excNullRef = "Object have NULL reference!";
		private const string excImposAdd = "Addition is impossible!";
		private const string excImposSub = "Subtraction is impossible!";
		private const string excImposMul = "Multiplication is impossible!";
		private double[,] matrix;
		private int strings;
		private int columns;

		public int Strings { get { return strings; } }
		public int Columns { get { return columns; } }
		public double[,] Array { get { return (double[,])matrix.Clone() ; } }
		public double this[int i, int j]
		{
			get
			{
				if (i < 0 || i >= strings || j < 0 || j > columns)
					throw new ArgumentException(excBadIndex);
				return matrix[i, j];
			}
			set
			{
				if (i < 0 || i >= strings || j < 0 || j > columns)
					throw new ArgumentException(excBadIndex);
				matrix[i, j] = value;
			}
		}

		public Matrix (int inputStrings, int inputColumns)
		{
			if (inputStrings <= 1 || inputColumns <= 1) throw new ArgumentException(excBadInput);
			strings = inputStrings;
			columns = inputColumns;
			matrix = new double[strings, columns];
		}
		public Matrix (double[,] array)
		{
			if (array == null) throw new ArgumentException(excBadInput);
			strings = array.GetLength(0);
			columns = array.GetLength(1);
			matrix = (double[,])array.Clone();
		}
		private double GetMatrixSum ()
		{
			double result = 0;
			foreach (double element in matrix)
			{
				result += element;
			}
			return result;
		}
		public int CompareTo(object obj)
		{
			if (obj == null) return 1;
			Matrix other = obj as Matrix;
			if (obj != null)
				return this.GetMatrixSum().CompareTo(other.GetMatrixSum());
			else
				throw new ArgumentException(excNotMatrix);
		}
		private double Determinant(double [,] array)
		{
			if (strings != columns) throw new ArgumentException(excExistDeterm);
			int n = (int)Math.Sqrt(array.Length);
			if (n == 1)
			{
				return array[0, 0];
			}
			double det = 0;
			for (int k = 0; k < n; k++)
			{
				det += array[0, k] * Cofactor(array, 0, k);
			}
			return det;
		}
		private double Cofactor(double[,] array, int row, int column)
		{
			return Convert.ToDouble(Math.Pow(-1, row + column) * Determinant(Minor(array, row, column)));
		}
		private double[,] Minor(double[,] array, int str, int column)
		{
			int dimension = (int)Math.Sqrt(array.Length);
			double[,] resultMatrix = new double[dimension - 1, dimension - 1];
			int x = 0;
			for (int i = 0; i < dimension; i++)
			{
				if (i == str) continue;
				int y = 0;
				for (int j = 0; j < dimension; j++)
				{
					if (j == column) continue;
					resultMatrix[x, y] = array[i, j];
					y++;
				}
				x++;
			}
			return resultMatrix;
		}
		public Matrix Transpose()
		{
			Matrix resultMatrix = new Matrix(columns, strings);
			for (int i = 0; i < strings; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					resultMatrix[j, i] = matrix[i, j];
				}
			}
			return resultMatrix;
		}
		public Matrix Inverse()
		{
			double det = Determinant(matrix);
			if (det == 0) throw new ArgumentException(excNullDeterm);
			Matrix resultMatrix = new Matrix(strings, columns);
			for (int i = 0; i < strings; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					resultMatrix.matrix[i, j] = Cofactor(matrix, i, j) / det;
				}
			}
			return resultMatrix.Transpose();
		}
		public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
		{
			if (firstMatrix == null || secondMatrix == null) throw new ArgumentException(excNullRef);
			if (firstMatrix.strings != secondMatrix.strings && firstMatrix.columns != secondMatrix.columns)
				throw new ArgumentException(excImposAdd);
			Matrix resultMatrix = new Matrix(firstMatrix.strings, firstMatrix.columns);
			for (int i = 0; i < firstMatrix.strings; i++)
			{
				for (int j = 0; j < firstMatrix.columns; j++)
				{
					resultMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
				}
			}
			return resultMatrix;
		}
		public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
		{
			if (firstMatrix == null || secondMatrix == null) throw new ArgumentException(excNullRef);
			if (firstMatrix.strings != secondMatrix.strings && firstMatrix.columns != secondMatrix.columns)
				throw new ArgumentException(excImposSub);
			Matrix resultMatrix = new Matrix(firstMatrix.strings, firstMatrix.columns);
			for (int i = 0; i < firstMatrix.strings; i++)
			{
				for (int j = 0; j < firstMatrix.columns; j++)
				{
					resultMatrix[i, j] = firstMatrix[i, j] - secondMatrix[i, j];
				}
			}
			return resultMatrix;
		}
		public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
		{
			if (firstMatrix == null || secondMatrix == null) throw new ArgumentException(excNullRef);
			if (firstMatrix.strings != secondMatrix.columns) throw new ArgumentException(excImposMul);
			Matrix resultMatrix = new Matrix(firstMatrix.strings, secondMatrix.columns);
			for (int i = 0; i < firstMatrix.strings; i++)
			{
				for (int j = 0; j < secondMatrix.columns; j++)
				{
					double sum = 0;
					for (int k = 0; k < firstMatrix.columns; k++)
					{
						sum += firstMatrix[i, k] * secondMatrix[k, j];
					}
					resultMatrix[i, j] = sum;
				}
			}
			return resultMatrix;
		}
		public override string ToString()
		{
			string result = string.Empty;
			for (int i = 0; i < strings; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					result += matrix[i, j] + "\t";
				}
				result += "\n";
			}
			return result;
		}
    }
}
