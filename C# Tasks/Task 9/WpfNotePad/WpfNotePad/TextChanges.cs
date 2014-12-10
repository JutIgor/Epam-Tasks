using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNotePad
{
	public class TextChanges
	{
		private int position;
		private string change;
		private bool added;
		private static int size = 0;
		public static int Size { get { return size; } }
		public bool Added { get { return added; } }
		public string Change { get { return change; } }
		public int Position { get { return position; } }

		public TextChanges(string let, int pos, bool choice)
		{
			position = pos;
			change = let;
			added = choice;
			if (choice) size++;
			else size--;
		}
	}
}
