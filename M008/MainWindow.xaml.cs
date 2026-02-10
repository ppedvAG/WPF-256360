using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace M008;

public partial class MainWindow : Window
{
	public ObservableCollection<int> Zahlen { get; set; } = new ObservableCollection<int>(Enumerable.Range(0, 10));

	public DayOfWeek[] Wochentage { get; } = Enum.GetValues<DayOfWeek>();

	public Color SelectedColor { get; set; }

	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{

	}
}