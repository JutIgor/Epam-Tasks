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
using Vector;

namespace WpfApplication1
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

		private void Button_Click(object sender, RoutedEventArgs e) // ButtonPlus
		{
			TextBoxOut.Clear();
			TextBoxOut.Text += Method.Addition(TextBoxV1.Text, TextBoxV2.Text);
		}

		private void Button_Click_1(object sender, RoutedEventArgs e) // ButtonMultiplicate
		{
			TextBoxOut.Clear();
			TextBoxOut.Text += Method.Multiplication(TextBoxV1.Text, TextBoxV2.Text);
		}

		private void ButtonMinus_Click(object sender, RoutedEventArgs e)
		{
			TextBoxOut.Clear();
			TextBoxOut.Text += Method.Difference(TextBoxV1.Text, TextBoxV2.Text);
		}

		private void ButtonLength_Click(object sender, RoutedEventArgs e)
		{
			TextBoxOut.Clear();
			TextBoxOut.Text += Method.Length(TextBoxV1.Text, TextBoxV2.Text);
		}

		private void ButtonAngle_Click(object sender, RoutedEventArgs e)
		{
			TextBoxOut.Clear();
			TextBoxOut.Text += Method.Angle(TextBoxV1.Text, TextBoxV2.Text);
		}



		//private double[] TryParse(string input)
		//{
		//	try
		//	{
		//		double[] result = Parse(input);
		//		return result;
		//	}
		//	catch(ArgumentException myEx)
		//	{
		//		MessageBox.Show(myEx.Message);
		//		return null;
		//	}
		//}
		//private double[] Parse (string input)
		//{
		//	List<double> inputList = new List<double>();
		//	RegexOptions option = RegexOptions.None;
		//	Regex pattern = new Regex(@"(-)?[0-9]+(\.[0-9]+)?", option);
		//	MatchCollection matches = pattern.Matches(input);
		//	if(matches.Count < 2)
		//	{
		//		throw new ArgumentException("Bad input!");
		//	}
		//	foreach (Match sample in matches)
		//	{
		//		inputList.Add(Convert.ToDouble(sample.Value.Replace('.', ',')));
		//	}
		//	double[] result = new double[inputList.Count];
		//	for (int i = 0; i < inputList.Count; i++)
		//	{
		//		result[i] = inputList[i];
		//	}
		//	return result;
		//}

		//private Vector.Vector CreateVector (string input)
		//{
		//	try
		//	{
		//		return new Vector.Vector(TryParse(input));
		//	}
		//	catch(ArgumentException myEx)
		//	{
		//		MessageBox.Show(myEx.Message);
		//		return null;
		//	}
		//}

	}
}
