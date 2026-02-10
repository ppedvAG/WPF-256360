using System.Windows;

namespace M000;

public partial class MainWindow : Window
{
	public Person DiePerson { get; set; } = new() { Gender = Geschlecht.D };

	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{

	}
}