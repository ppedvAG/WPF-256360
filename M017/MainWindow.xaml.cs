using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace M017;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();

		double[] x = Enumerable.Range(0, 10).Select(e => (double) e).ToArray();
		double[] y = Enumerable.Range(0, 10).Select(e => (double) Random.Shared.Next(0, 10)).ToArray();

		//Plot.Plot.Add.ScatterLine(x, y);
		//Plot.Plot.Add.Line(0, 5, 10, 5);

		Plot.Plot.Add.Pie(y);
		//Plot.Refresh();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		double[] y = Enumerable.Range(0, 10).Select(e => (double) Random.Shared.Next(0, 10)).ToArray();
		Plot.Plot.Add.Pie(y);
		Plot.Refresh();

		//Datei öffnen & speichern (Microsoft.Win32)
		OpenFileDialog o = new OpenFileDialog();

		o.ShowDialog();

		string file = o.FileName;
		string content = File.ReadAllText(file);
		//...

		//CSV: TextFieldParser (intern), CSVHelper (NuGet)
	}
}