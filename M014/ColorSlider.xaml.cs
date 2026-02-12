using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace M014;

public partial class ColorSlider : UserControl
{
	/// <summary>
	/// propdp + Tab + Tab
	/// </summary>
	public string Text
	{
		get => (string) GetValue(TextProperty);
		set => SetValue(TextProperty, value);
	}

	public static readonly DependencyProperty TextProperty =
		DependencyProperty.Register
		(
			nameof(Text), //Name des Properties
			typeof(string), //Typ des Properties
			typeof(ColorSlider) //Typ der Klasse (in dem dieses Property sich befindet)
		);




	public Color TextColor
	{
		get { return (Color) GetValue(TextColorProperty); }
		set { SetValue(TextColorProperty, value); }
	}

	public static readonly DependencyProperty TextColorProperty =
		DependencyProperty.Register(nameof(TextColor), typeof(Color), typeof(ColorSlider), new PropertyMetadata(Colors.Black));






	public double SliderValue
	{
		get { return (double) GetValue(SliderValueProperty); }
		set { SetValue(SliderValueProperty, value); }
	}

	// Using a DependencyProperty as the backing store for SliderValue.  This enables animation, styling, binding, etc...
	public static readonly DependencyProperty SliderValueProperty =
		DependencyProperty.Register(nameof(SliderValue), typeof(double), typeof(ColorSlider), new PropertyMetadata(0.0));




	public ColorSlider()
	{
		InitializeComponent();
	}
}
