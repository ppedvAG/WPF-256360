using System.Globalization;
using System.Windows.Controls;

namespace M009;

class LetterValidation : ValidationRule
{
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		string s = value as string; //Sanfte Konvertierung: Gibt null zurück, wenn diese fehlschlägt
		//string s = (string) value; //Strike Konvertierung: Stürzt ab, wenn diese fehlschlägt

		if (s == null)
			return new ValidationResult(false, "Gib einen Text ein.");

		if (!s.All(char.IsLetter))
			return new ValidationResult(false, "Der eingegebene Text enthält nicht-Buchstaben!");

		return ValidationResult.ValidResult; //Source Code: github.com/dotnet/wpf
	}
}
