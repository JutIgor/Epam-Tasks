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
using System.Diagnostics;

namespace FloatMenu
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

		private void ConsoleButton_Click(object sender, RoutedEventArgs e)
		{
			Process.Start(@"\\psf\Home\Documents\Visual Studio 2013\Projects\Epam Tasks\Task 1\FloatConsole\FloatConsole\bin\Debug\FloatConsole.exe");
		}

		private void FileButton_Click(object sender, RoutedEventArgs e)
		{
			Process.Start(@"\\psf\Home\Documents\Visual Studio 2013\Projects\Epam Tasks\Task 1\FloatFile\FloatFile\bin\Debug\FloatFile.exe");
		}

		private void WPFButton_Click(object sender, RoutedEventArgs e)
		{
			Process.Start(@"\\psf\Home\Documents\Visual Studio 2013\Projects\Epam Tasks\Task 1\FloatWPF\FloatWPF\bin\Debug\FloatWPF.exe");
		}
	}
}
