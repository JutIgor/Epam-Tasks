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
using Newton;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private static string StringExceptionRuntime = "Houston, we have a problem!";
		public MainWindow()
		{
			InitializeComponent();
		}

		private void CountButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				OutputTextBox.Clear();
				string choice = "n";
				if ((bool)CompareCheckBox.IsChecked)
				{
					choice = "y";
				}
				List<double> resultList = new List<double>();
				resultList = Newton.Input.Method(NumberTextBox.Text, PowerTextBox.Text, PrecisionTextBox.Text, choice);
				OutputTextBox.Text += "Root (Newton): \r\n";
				OutputTextBox.Text += resultList[0];
				if (resultList.Count == 2)
				{
					OutputTextBox.Text += "\r\nRoot (Math.Pow): \r\n";
					OutputTextBox.Text += resultList[1];
				}
			}
			catch (ArgumentException MyException)
			{
				MessageBox.Show(MyException.Message);
			}
			catch (Exception)
			{

				MessageBox.Show(StringExceptionRuntime);
			}
		}

	}
}
