using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
	public class Method
	{
		public static string Addition(string input1, string input2)
		{
			try
			{
				Vector.Vector v1 = new Vector.Vector(Vector.Process.Parse(input1));
				Vector.Vector v2 = new Vector.Vector(Vector.Process.Parse(input2));
				return "v1 + v2 = " + Vector.Process.Show(v1 + v2);
			}
			catch(ArgumentException myEx)
			{
				return myEx.Message;
			}
		}

		public static string Difference(string input1, string input2)
		{
			try
			{
				Vector.Vector v1 = new Vector.Vector(Vector.Process.Parse(input1));
				Vector.Vector v2 = new Vector.Vector(Vector.Process.Parse(input2));
				return "v1 - v2 = " + Vector.Process.Show(v1 - v2);
			}
			catch(ArgumentException myEx)
			{
				return myEx.Message;
			}
		}

		public static string Multiplication(string input1, string input2)
		{
			try
			{
				Vector.Vector v1 = new Vector.Vector(Vector.Process.Parse(input1));
				Vector.Vector v2 = new Vector.Vector(Vector.Process.Parse(input2));
				return "v1 * v2 = " + v1 * v2;
			}
			catch(ArgumentException myEx)
			{
				return myEx.Message;
			}
		}

		public static string Length(string input1, string input2)
		{
			try
			{
				Vector.Vector v1 = new Vector.Vector(Vector.Process.Parse(input1));
				Vector.Vector v2 = new Vector.Vector(Vector.Process.Parse(input2));
				return "v1 = " + v1.Length() + ";  v2 = " + v2.Length();
			}
			catch(ArgumentException myEx)
			{
				return myEx.Message;
			}
		}

		public static string Angle(string input1, string input2)
		{
			try
			{
				Vector.Vector v1 = new Vector.Vector(Vector.Process.Parse(input1));
				Vector.Vector v2 = new Vector.Vector(Vector.Process.Parse(input2));
				return "cos(v1^v2): " + Vector.Vector.Angle(v1,v2).ToString();
			}
			catch(ArgumentException myEx)
			{
				return myEx.Message;
			}
		}
	}
}
