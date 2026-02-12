using System.Windows.Input;

namespace M012;

/// <summary>
/// Alternative Namen: RelayCommand, DelegateCommand
/// </summary>
public class CustomCommand : ICommand
{
	//3 Anforderungen: Behälter für Execute und CanExecute, Konstruktor um diese Methodenzeiger zu empfangen

	private Action<object> _execute;

	private Func<object, bool> _canExecute;

	/// <summary>
	/// Action<object>: Methodenzeiger, der void zurückgibt, und einen object Parameter hat
	/// Func<object>: Methodenzeiger, der einen beliebigen Typen zurückgibt, und einen object Parameter hat
	/// 
	/// canExecute = null: Optionaler Parameter
	/// </summary>
	public CustomCommand(Action<object> execute, Func<object, bool> canExecute = null)
	{
		_execute = execute;
		_canExecute = canExecute;
	}

	////////////////////////////////////////////////////////////

	public event EventHandler? CanExecuteChanged;

	public void Execute(object? parameter)
	{
		_execute(parameter); //Führe den oben gespeicherten Methodenzeiger hier aus
	}

	public bool CanExecute(object? parameter)
	{
		if (_canExecute == null)
			return true;
		return _canExecute(parameter);
	}
}