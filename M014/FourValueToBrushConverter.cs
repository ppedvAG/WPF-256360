using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace M014;

public class FourValueToBrushConverter : IMultiValueConverter
{
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		byte[] b = values.Select(e => (byte) (double) e).ToArray();
		return new SolidColorBrush(Color.FromArgb(b[3], b[0], b[1], b[2]));
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
