using System.Windows.Data;
using System.Windows.Markup;

namespace M008;

class ConverterExtension : MarkupExtension
{
	public Type ConverterType { get; set; }

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (ConverterType.GetInterface(nameof(IValueConverter)) == null)
			throw new ArgumentException("ConverterType muss das IValueConverter Interface haben");

		return Activator.CreateInstance(ConverterType);
	}
}
