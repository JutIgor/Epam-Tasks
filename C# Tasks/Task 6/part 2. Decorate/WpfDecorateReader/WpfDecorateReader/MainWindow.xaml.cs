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
using System.Windows.Controls.Primitives;

namespace WpfDecorateReader
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private Decorate dStream;
		private bool entry = false;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			ScrollBar.Scroll += ScrollBarScroll;
		}

		private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{

		}
		private void ScrollBarScroll(object sender, ScrollEventArgs scrollEventArgs)
		{
			if (ProgressBar.Value < ScrollBar.Value) ProgressBar.Value = ScrollBar.Value;
			if(entry)
			{
				TextBoxOut.Text += dStream.ReadText(ScrollBar.Value);
				TextBoxOut.ScrollToEnd();
			}
		}

		private void ButtonConfirm_Click(object sender, RoutedEventArgs e)
		{
			Entry(TextBoxPassword.Text);
			if(entry) TextBoxPassword.IsEnabled = false;
		}
		private void Entry (string pasString)
		{
			try
			{
				TextBoxOut.Clear();
				ProgressBar.Value = ProgressBar.Minimum;
				ScrollBar.Value = ScrollBar.Minimum;
				dStream = new Decorate(pasString);
				entry = true;
			}
			catch(ArgumentException myEx)
			{
				MessageBox.Show(myEx.Message);
				entry = false;
			}
		}
	}
}
