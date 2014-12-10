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
using Convert;

namespace WpfApplication
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private static string ExcMes = "Houston, we have a problem!";
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			OutputTextBox.Clear();
			OutputTextBox.Text += Change(InputTextBox.Text);
		}

		private string Change (string Input)
		{
			try
			{
				return ProcessingInput.Method(Input);
			}
			catch (ArgumentException MyE)
			{
				return MyE.Message;
			}
			catch (Exception)
			{
				return ExcMes;
			}
		}
	}
}
