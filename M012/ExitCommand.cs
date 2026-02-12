using System.Windows.Input;

namespace M012;

public class ExitCommand : ICommand
{
	public event EventHandler? CanExecuteChanged;

	/// <summary>
	/// Wird beim Button Klick ausgeführt
	/// </summary>
	public void Execute(object? parameter)
	{
		Environment.Exit(0);
	}

	/// <summary>
	/// Wenn diese Methode true zurückgibt, ist der Button aktiviert, sonst deaktiviert
	/// </summary>
	public bool CanExecute(object? parameter)
	{
		return true;
	}
}