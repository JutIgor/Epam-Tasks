using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfDecorateReader
{
	public class MyReader: TextReader
	{
		private string Path;
//@"\\psf\Home\Documents\Visual Studio 2013\Projects\Epam Tasks\Task 6\part 2. Decorate\WpfDecorateReader\Input.txt";// передавать в конструктор
		private StreamReader strReader;
		public MyReader ()
		{
			Path = null;
		}
		public MyReader (string path)
		{
			Path = path;
			strReader = new StreamReader(Path);
		}
		public char[] Read(int count)
		{
			char[] buf = new char [count];
			strReader.ReadBlock(buf, 0, count);
			return buf;
		}
		public int TextLength()
		{
			return new StreamReader(this.Path).ReadToEnd().Length;
		}

	}
}
