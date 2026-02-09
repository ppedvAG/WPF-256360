using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace M002;

public partial class MainWindow : Window
{
	public int Counter;

	public MainWindow()
	{
		InitializeComponent();

		Zahlen.ItemsSource = Enumerable.Range(0, 10);
		LB.ItemsSource = Enumerable.Range(0, 10);
		IC.ItemsSource = Enumerable.Range(0, 10);
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		MessageBoxResult result = MessageBox.Show("Zähler hochzählen?", "Zähler", MessageBoxButton.YesNo, MessageBoxImage.Question);
		if (result == MessageBoxResult.Yes)
		{
			Counter++;
			Output.Text = "Zähler: " + Counter;
		}
	}

	private void Button_Click_1(object sender, RoutedEventArgs e)
	{
		Output.Text = "Hallo " + Eingabe.Text;
	}

	private void Eingabe_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Enter)
			Output.Text = "Hallo " + Eingabe.Text;
	}

	private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		Output.Text = Dropdown.SelectedItem.ToString();
	}

	private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		Output.Text = e.NewValue.ToString();
	}
}