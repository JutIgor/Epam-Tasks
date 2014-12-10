using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExtractFloat;

namespace FloatWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		/// <summary>
		/// This method get input string from GetInput(), convert to floats separated by coma by method Extract()
		/// and display result.
		/// </summary>
		private void ConvertFloat ()
		{
			OutputTextBox.Clear();
			string Input = GetInput();
			if (Input == "\r\n")
			{
				Input = "";
			}
			List<string> Floats = FloatList.Extract(Input);
			for (int i = 0; i < Floats.Count; i++)
			{
				OutputTextBox.Text += Floats[i] + "\r\n";
			}
		}
		/// <summary>
		/// This method get all data from RichTextBox to InputString
		/// </summary>
		/// <returns>Data from RichTextBox</returns>
		private string GetInput()
		{
			string InputString = new TextRange(InputRichTextBox.Document.ContentStart, InputRichTextBox.Document.ContentEnd).Text;
			return InputString;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			ConvertFloat();
		}
	}
}
