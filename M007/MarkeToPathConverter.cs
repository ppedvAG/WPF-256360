using System.Globalization;
using System.Windows.Data;

namespace M007;

class MarkeToPathConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		FahrzeugMarke m = (FahrzeugMarke)value;
		string pathRoot = @"C:\Users\lk3\source\repos\WPF_2026_02_09\M007\Images\";
		return pathRoot + m.ToString() + ".png";
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
