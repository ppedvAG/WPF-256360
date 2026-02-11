using System.Windows;

namespace M010;

public partial class MainWindow : Window
{
	public bool TwoOfFour => new bool[] { CB1Checked, CB2Checked, CB3Checked, CB4Checked }.Count(e => e == true) >= 2;

	public bool CB1Checked { get; set; }

	public bool CB2Checked { get; set; }

	public bool CB3Checked { get; set; }

	public bool CB4Checked { get; set; }

	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{

	}
}