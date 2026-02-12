using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace M014;

class ColorToBrushConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		Color c = (Color)value;
		return new SolidColorBrush(c);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
