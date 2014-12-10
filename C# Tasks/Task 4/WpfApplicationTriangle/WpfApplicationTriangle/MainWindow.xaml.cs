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
using Triangle;

namespace WpfApplicationTriangle
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

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				Method(inputTextBox.Text);
			}
			catch(ArgumentException MyEx)
			{
				MessageBox.Show(MyEx.Message);
			}
		}

		private void Method(string input)
		{
			pTextBox.Clear();
			sTextBox.Clear();
			double[] result = ProcInput.Method(input);
			Triangle.Triangle obj;
			if(result.Length == 3)
			{
				obj = new Triangle.Triangle(result[0], result[1], result[2]);
			}
			else
			{
				obj = new Triangle.Triangle(result);
			}
			pTextBox.Text += obj.Perimeter().ToString();
			sTextBox.Text += obj.Square().ToString();
		}
	}
}
