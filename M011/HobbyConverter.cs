using System.Globalization;
using System.Windows.Data;

namespace M011;

class HobbyConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		IEnumerable<string> h = value as IEnumerable<string>;
		return string.Join(", ", h);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
