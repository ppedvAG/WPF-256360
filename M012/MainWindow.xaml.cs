using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace M012;

public partial class MainWindow : Window, INotifyPropertyChanged
{
	public ExitCommand ExitCommand { get; set; } = new ExitCommand();

	//Problem: Für jeden Button in der Anwendung, wird eine eigene Command Klasse benötigt
	//-> in großen Projekten sehr viele Command Klassen
	//Lösung: Generisches Command; Command, welches Methodenzeiger empfängt, und diese ausführt

	public CustomCommand CustomCommand { get; set; }

	public CustomCommand CustomCommand2 { get; set; }

	public CustomCommand EnterCommand {  get; set; }

	////////////////////////////////////////////

	private int counter;

	public int Counter
	{
		get => counter;
		set
		{
			counter = value;
			Notify();
		}
	}

	private string output;

	public string Output
	{
		get => output;
		set
		{
			output = value;
			Notify();
		}
	}

	public MainWindow()
	{
		CustomCommand = new CustomCommand(Exit);
		CustomCommand2 = new CustomCommand(CounterIncrement);
		EnterCommand = new CustomCommand(EnterPressed);
		InitializeComponent();
	}

	public void Exit(object o)
	{
		Environment.Exit(0);
	}

	public void CounterIncrement(object o)
	{
		Counter++;
	}

	public void EnterPressed(object o)
	{
		KeyEventArgs e = (KeyEventArgs)o;
		if (e.Key == Key.Enter)
		{
			Output = TB.Text;
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
}