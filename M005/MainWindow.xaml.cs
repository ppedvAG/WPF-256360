using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace M005;

public partial class MainWindow : Window, INotifyPropertyChanged
{
	/// <summary>
	/// WICHTIG: Data Binding Properties müssen { get; set; } haben
	/// </summary>
	private int counter = 3;

	/// <summary>
	/// Strg + .: Convert to full property
	/// </summary>
	public int Counter
	{
		get => counter;
		set
		{
			counter = value;
			Notify(); //nameof(Counter) -> "Counter" (Vorteil: Wird bei Refactoring auch angepasst)
		}
	}

	/// <summary>
	/// ObservableCollection komplett ändern: Clear() + Schleife über neue Elemente mit Add(...)
	/// </summary>
	public ObservableCollection<Fahrzeug> Fahrzeuge { get; set; } =
	[
		new Fahrzeug(251, FahrzeugMarke.BMW),
		new Fahrzeug(274, FahrzeugMarke.BMW),
		new Fahrzeug(146, FahrzeugMarke.BMW),
		new Fahrzeug(208, FahrzeugMarke.Audi),
		new Fahrzeug(189, FahrzeugMarke.Audi),
		new Fahrzeug(133, FahrzeugMarke.VW),
		new Fahrzeug(253, FahrzeugMarke.VW),
		new Fahrzeug(304, FahrzeugMarke.BMW),
		new Fahrzeug(151, FahrzeugMarke.VW),
		new Fahrzeug(250, FahrzeugMarke.VW),
		new Fahrzeug(217, FahrzeugMarke.Audi),
		new Fahrzeug(125, FahrzeugMarke.Audi)
	];

	public MainWindow()
	{
		InitializeComponent();
		//this.DataContext = this;
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Counter++;
		//Kein GUI Update
		//Notify("Counter"); //Benachrichtigung an die GUI senden
	}

	////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Benachrichtigungsmechanismus
	/// 
	/// Wenn die Notify Methode aufgerufen wird, bekommt die GUI eine Benachrichtigung über die Änderung
	/// </summary>
	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
}