using System.Windows.Markup;

namespace M008;

public class EnumExtension : MarkupExtension
{
	public Type EnumType { get; set; }

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (EnumType == null)
			throw new ArgumentNullException("EnumType muss gesetzt sein");

		if (!EnumType.IsEnum)
			throw new ArgumentException("EnumType muss ein Enum Typ sein");

		return Enum.GetValues(EnumType);
	}
}
