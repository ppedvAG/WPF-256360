using System.Globalization;
using System.Windows.Data;

namespace M000;

class BooleanToGenderConverter : IValueConverter
{
	//Backend -> Frontend (Person Objekt zu RadioButton)
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		Geschlecht v = (Geschlecht)value;
		Geschlecht p = (Geschlecht)parameter;
		return v == p;
	}

	//Frontend -> Backend (RadioButton -> Person)
	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		bool b = (bool) value;
		Geschlecht g = (Geschlecht) parameter;

		if (b == true)
			return g;
		else
			return Binding.DoNothing;
	}
}
