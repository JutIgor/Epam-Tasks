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
using System.Windows.Controls.DataVisualization.Charting;
using System.Diagnostics;
using NOD;

namespace WpfApplicationNOD
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Chart.DataContext = new List<KeyValuePair<string, int>>
													  {
														  new KeyValuePair <string, int>("Euklid",0),
														  new KeyValuePair<string, int>("Stein",0)
													  };
		}

		private void ProcButton_Click(object sender, RoutedEventArgs e)
		{
			Process();
		}

		public void Process ()
		{
			try
			{
				Stopwatch timeEuklid = new Stopwatch();
				Stopwatch timeStein = new Stopwatch();
				OutputTextBox.Text = "NOD: " + ProcInput.MethodNOD(out timeEuklid, InputTextBox.Text, true);
				string a = ProcInput.MethodNOD(out timeStein, InputTextBox.Text, false);
				Chart.DataContext = new List<KeyValuePair<string, int>>
                                                      {
                                                          new KeyValuePair <string, int>("Euklid",(int)timeEuklid.ElapsedTicks),
                                                          new KeyValuePair<string, int>("Stein",(int)timeStein.ElapsedTicks)
                                                      };
			}
			catch (ArgumentException MyEx)
			{
				MessageBox.Show(MyEx.Message);
			}
			catch (Exception)
			{
				MessageBox.Show("Houston, we have a broblem!");
			}
		}
	}
}
