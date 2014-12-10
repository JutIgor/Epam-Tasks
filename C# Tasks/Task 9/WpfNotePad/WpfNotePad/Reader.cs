using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WpfNotePad
{
	public class Reader: TextReader, IDisposable
	{
		private OpenFileDialog OpenFile;
		private string PathFile;
		private FileStream strFile;
		public Reader ()
		{
			OpenFile = new OpenFileDialog { Filter = "Text files|*.txt" };
			ChooseFile();
		}
		public void ChooseFile()
		{
			OpenFile.ShowDialog();
			PathFile = OpenFile.FileName;
			if (PathFile == string.Empty) throw new ArgumentException("Choose file!");
		}
		public char[] Read(int count, int curIndex)
		{
			strFile = new FileStream(PathFile, FileMode.Open);
			strFile.Seek(curIndex, SeekOrigin.Begin);
			byte[] array = new byte [count];
			strFile.Read(array, 0, count);
			char[] buf = new char[count];
			for (int i = 0; i < array.Length; i++)
			{
				buf[i] = Convert.ToChar(array[i]);
			}
			strFile.Close();
			return buf;
		}

		public void Write(List<TextChanges> changes, int length)
		{
			if (TextChanges.Size > 0)
			{
				strFile = new FileStream(PathFile, FileMode.Open);
				length += TextChanges.Size;
				strFile.SetLength(length);
				strFile.Close();
			}
			foreach (TextChanges change in changes)
			{
				if(change.Added)
				{
					strFile = new FileStream(PathFile, FileMode.Open);
					strFile.Seek(change.Position, SeekOrigin.Begin);
					byte[] array = new byte[length - change.Position];
					strFile.Read(array, 0, length - change.Position);
					strFile.Seek(change.Position, SeekOrigin.Begin);
					byte[] arrayCh = new byte[1];
					arrayCh[0] = Convert.ToByte(change.Change[0]);
					strFile.Write(arrayCh, 0, 1);
					strFile.Write(array, 0, array.Length);
					strFile.Close();
				}
				else if(!change.Added)
				{
					strFile = new FileStream(PathFile, FileMode.Open);
					strFile.Seek(change.Position + 1, SeekOrigin.Begin);
					byte[] array = new byte[length - change.Position];
					strFile.Read(array, 0, length - change.Position);
					strFile.Seek(change.Position, SeekOrigin.Begin);
					strFile.Write(array, 0, array.Length);
					strFile.Close();
				}
				if (TextChanges.Size <= 0)
				{
					strFile = new FileStream(PathFile, FileMode.Open);
					length += TextChanges.Size;
					strFile.SetLength(length);
					strFile.Close();
				}
			}
		}
		public int TextLength()
		{
			StreamReader obj = new StreamReader(PathFile);
			int length = obj.ReadToEnd().Length;
			obj.Dispose();
			return length;
		}
	}
}
