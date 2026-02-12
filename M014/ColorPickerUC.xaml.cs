using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace M014;

/// <summary>
/// Aufgaben:
/// - Alle 4 Slider als Properties darstellen
/// - PickedColor als Property darstellen
/// </summary>
public partial class ColorPickerUC : UserControl
{
	public double R
	{
		get { return (double) GetValue(RProperty); }
		set { SetValue(RProperty, value); }
	}

	public static readonly DependencyProperty RProperty =
		DependencyProperty.Register(nameof(R), typeof(double), typeof(ColorPickerUC), new PropertyMetadata(0.0, SliderValueChanged));


	public double G
	{
		get { return (double) GetValue(GProperty); }
		set { SetValue(GProperty, value); }
	}

	public static readonly DependencyProperty GProperty =
		DependencyProperty.Register(nameof(G), typeof(double), typeof(ColorPickerUC), new PropertyMetadata(0.0, SliderValueChanged));


	public double B
	{
		get { return (double) GetValue(BProperty); }
		set { SetValue(BProperty, value); }
	}

	public static readonly DependencyProperty BProperty =
		DependencyProperty.Register(nameof(B), typeof(double), typeof(ColorPickerUC), new PropertyMetadata(0.0, SliderValueChanged));


	public double A
	{
		get { return (double) GetValue(AProperty); }
		set { SetValue(AProperty, value); }
	}

	public static readonly DependencyProperty AProperty =
		DependencyProperty.Register(nameof(A), typeof(double), typeof(ColorPickerUC), new PropertyMetadata(255.0, SliderValueChanged));



	public Color PickedColor
	{
		get { return (Color) GetValue(PickedColorProperty); }
		set { SetValue(PickedColorProperty, value); }
	}

	public static readonly DependencyProperty PickedColorProperty =
		DependencyProperty.Register(nameof(PickedColor), typeof(Color), typeof(ColorPickerUC), new PropertyMetadata(PickedColorChanged));

	/// <summary>
	/// Diese Methode wird immer aufgerufen, wenn ein Slider seinen Wert ändert
	/// </summary>
	public static void SliderValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		byte r = (byte) (double) d.GetValue(RProperty);
		byte g = (byte) (double) d.GetValue(GProperty);
		byte b = (byte) (double) d.GetValue(BProperty);
		byte a = (byte) (double) d.GetValue(AProperty);

		Color c = Color.FromArgb(a, r, g, b);
		d.SetValue(PickedColorProperty, c);
	}

	public static void PickedColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		Color c = (Color) d.GetValue(PickedColorProperty);

		byte r = c.R;
		byte g = c.G;
		byte b = c.B;
		byte a = c.A;

		d.SetValue(RProperty, (double) r);
		d.SetValue(GProperty, (double) g);
		d.SetValue(BProperty, (double) b);
		d.SetValue(AProperty, (double) a);
	}

	public ColorPickerUC()
	{
		InitializeComponent();
	}
}
