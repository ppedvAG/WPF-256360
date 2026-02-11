using System.ComponentModel;
using System.Windows;

namespace M009;

public partial class MainWindow : Window, IDataErrorInfo
{
	public string Eingabe { get; set; }


	private string eingabe2;

	public string Eingabe2
	{
		get => eingabe2;
		set
		{
			if (value == null)
				throw new ArgumentException("Gib einen Text ein.");

			if (value.Length < 3 || value.Length > 15)
				throw new ArgumentException($"Eingabe muss zw. 3 und 15 Zeichen lang sein!");

			eingabe2 = value;
		}
	}

	public string Eingabe3 { get; set; }

	/// <summary>
	/// Kann ignoriert werden
	/// </summary>
	public string Error => throw new NotImplementedException();

	/// <summary>
	/// Indexer
	/// 
	/// Wird normalerweise verwendet, um Listentypen mit [ ] anzugreifen
	/// </summary>
	public string this[string prop]
	{
		get
		{
			switch (prop)
			{
				case "Eingabe3":
					if (Eingabe3 == null)
						return "Gib einen Text ein.";

					if (!Eingabe3.All(char.IsLetter))
						return "Der eingegebene Text enthält nicht-Buchstaben!";

					return null;
			}

			return null;
		}
	}

	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{

	}
}