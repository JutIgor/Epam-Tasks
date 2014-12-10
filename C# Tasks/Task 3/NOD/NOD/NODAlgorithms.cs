using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NOD
{
    public class NODAlgorithms
    {
		/// <summary>
		/// Euclidean algorithm
		/// </summary>
		/// <param name="Number_F"></param>
		/// <param name="Number_S"></param>
		/// <returns></returns>
		private static int Euklid (int Number_F, int Number_S)
		{
			while (Number_S != 0)
				Number_S = Number_F % (Number_F = Number_S);
			return Number_F;
		}
		/// <summary>
		/// Function Euklid returns GCD of input Numbers
		/// </summary>
		/// <param name="WatchEuklid"></param>
		/// <param name="Input"></param>
		/// <returns></returns>
		public static int Euklid (out Stopwatch WatchEuklid, params int[] Input)
		{
			WatchEuklid = new Stopwatch();
			WatchEuklid.Start();
			int i = 0;
			while (i != Input.Length - 1)
			{
				Input[i + 1] = Euklid(Input[i], Input[i + 1]);
				i++;
			}
			WatchEuklid.Stop();
			return Input[i];
		}
		/// <summary>
		/// Binary euclidean algorithm
		/// </summary>
		/// <param name="Number_F"></param>
		/// <param name="Number_S"></param>
		/// <returns></returns>
		private static int Stein (int Number_F, int Number_S)
		{
			if (Number_F == 0) return Number_S;
			if (Number_S == 0) return Number_F;
			if (Number_F == Number_S) return Number_F;
			if (Number_F == 1 || Number_S == 1) return 1;
			if ((Number_F % 2 == 0) && (Number_S % 2 == 0)) return 2 * Stein(Number_F / 2, Number_S / 2);
			if ((Number_F % 2 == 0) && (Number_S % 2 != 0)) return Stein(Number_F / 2, Number_S);
			if ((Number_F % 2 != 0) && (Number_S % 2 == 0)) return Stein(Number_F, Number_S / 2);
			return Stein(Number_S, Math.Abs(Number_F - Number_S));
		}
		/// <summary>
		/// Function Stein returns GCD of input Numbers
		/// </summary>
		/// <param name="WatchStein"></param>
		/// <param name="Input"></param>
		/// <returns></returns>
		public static int Stein (out Stopwatch WatchStein, params int[] Input)
		{
			WatchStein = new Stopwatch();
			WatchStein.Start();
			int i = 0;
			while (i != Input.Length - 1)
			{
				Input[i + 1] = Euklid(Input[i], Input[i + 1]);
				i++;
			}
			WatchStein.Stop();
			return Input[i];
		}
    }
}
