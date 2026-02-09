using System.Globalization;
using System.Windows.Data;

namespace M004;

class ScoreToGradeConverter : IValueConverter
{
	/// <summary>
	/// Quelle zu Ziel
	/// Slider zu TextBlock
	/// double zu string
	/// </summary>
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		double d = (double) value; //object zu double konvertieren
		int i = (int) d;

		switch (i)
		{
			case <= 50: return $"Ungenügend ({i})";
			case <= 60: return $"Mangelhaft ({i})";
			case <= 70: return $"Ausreichend ({i})";
			case <= 80: return $"Befriedigend ({i})";
			case <= 90: return $"Gut ({i})";
			default: return $"Sehr Gut ({i})";
		}
	}

	/// <summary>
	/// Ziel zu Quelle
	/// TextBlock zu Slider
	/// Muss nicht implementiert werden
	/// </summary>
	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return 0;
	}
}
