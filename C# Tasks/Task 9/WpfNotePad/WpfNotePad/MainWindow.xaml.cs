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

namespace WpfNotePad
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private List<TextChanges> Changes = new List<TextChanges>();
		private Decorate DecoratedStream;
		private bool entry = false;
		private StringBuilder str = new StringBuilder();
		public MainWindow()
		{
			InitializeComponent();
		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			foreach (var change in e.Changes)
			{
				if (change.AddedLength == 1 && change.RemovedLength == 0)
				{
					str.Append(TextBox.Text[change.Offset]);
					Changes.Add(new TextChanges(str.ToString(), change.Offset, true));
					str.Clear();
				}
				else if (change.AddedLength == 0 && change.RemovedLength == 1)
				{
					str.Append(TextBox.Text[change.Offset]);
					Changes.Add(new TextChanges(str.ToString(), change.Offset, false));
					str.Clear();
				}
			}
		}

		private void ButtonLoad_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				DecoratedStream = new Decorate();
				ScrollBar.Value = ScrollBar.Minimum;
				ButtonSave.IsEnabled = true;
				ScrollBar.IsEnabled = true;
				entry = true;
				ButtonLoad.IsEnabled = false;
			}
			catch(ArgumentException myExc)
			{
				MessageBox.Show(myExc.Message);
			}
		}

		private void ButtonSave_Click(object sender, RoutedEventArgs e)
		{
			DecoratedStream.Save(Changes);
		}

		private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			ScrollBar.Scroll += ScrollBar_Scroll;
		}

		private void ScrollBar_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
		{
			if (entry)
			{
				TextBox.Text += DecoratedStream.ReadText(ScrollBar.Value);
				TextBox.ScrollToEnd();
			}
		}
	}
}
