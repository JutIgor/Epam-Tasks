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
using System.Text.RegularExpressions;
using Polynom;

namespace WpfPolynom
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

		private void ButtonShow_Click(object sender, RoutedEventArgs e)
		{
			TextBoxOut.Clear();
			TextBoxOut.Text += Method.Show(TextBoxP1.Text, TextBoxP2.Text);
		}

		private void ButtonEqual_Click(object sender, RoutedEventArgs e)
		{
			TextBoxOut.Clear();
			TextBoxOut.Text += Method.Equal(TextBoxP1.Text, TextBoxP2.Text, true);
		}

		private void ButtonNotEqual_Click(object sender, RoutedEventArgs e)
		{
			TextBoxOut.Clear();
			TextBoxOut.Text += Method.Equal(TextBoxP1.Text, TextBoxP2.Text, false);
		}

		private void ButtonCount_Click(object sender, RoutedEventArgs e)
		{
			TextBoxOut.Clear();
			TextBoxOut.Text += Method.Count(TextBoxP1.Text, TextBoxP2.Text, Convert.ToDouble(TextBoxCount.Text));
		}
	}
}
