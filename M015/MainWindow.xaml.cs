using System.Windows;

namespace M015;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
		InitializeComponent();
	}
}