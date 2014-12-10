using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ExtractFloat;

namespace FloatFile
{
	class Program
	{
		static void Main(string[] args)
		{
			string PathInput = @"\\psf\Home\Documents\Visual Studio 2013\Projects\FloatFile\Input.txt";
			string PathOutput = @"\\psf\Home\Documents\Visual Studio 2013\Projects\FloatFile\Output.txt";
			//File.Delete(PathOutput);
			//string[] InputText = File.ReadAllLines(PathInput);
			//string Sample = "", ResultString = "";
			//for (int i = 0; i < InputText.Length; i++)
			//{
			//	Sample += InputText[i];
			//}
			//List<string> Floats = FloatList.Extract(Sample);
			//for (int i = 0; i < Floats.Count; i++)
			//{
			//	ResultString += Floats[i];
			//	ResultString += "\r\n";
			//}
			//File.WriteAllText(PathOutput, ResultString);
			
			string FileString = "";
			using (StreamReader Input = new StreamReader(PathInput))
			{
				using (StreamWriter Output = new StreamWriter(PathOutput, false))
				{
					while (!Input.EndOfStream)
					{
						FileString += Input.ReadLine();
					}
					List<string> Floats = FloatList.Extract(FileString);
					for (int i = 0; i < Floats.Count; i++)
					{
						Output.WriteLine(Floats[i]);
					}
				}
			}
		}
	}
}
