using System.Globalization;
using System.Windows.Controls;

namespace M009;

public class LengthValidation : ValidationRule
{
	public int Min { get; set; }

	public int Max { get; set; }

	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		string s = value as string;

		if (s == null)
			return new ValidationResult(false, "Gib einen Text ein.");

		if (s.Length < Min || s.Length > Max)
			return new ValidationResult(false, $"Eingabe muss zw. {Min} und {Max} Zeichen lang sein!");

		return ValidationResult.ValidResult;
	}
}
