using System.Diagnostics;

namespace M016;

[DebuggerDisplay("MaxV: {MaxV}, Marke: {Marke}")]
public class Fahrzeug
{
	public int MaxV { get; set; }

	public FahrzeugMarke Marke { get; set; }

	public Fahrzeug(int maxV, FahrzeugMarke marke)
	{
		MaxV = maxV;
		Marke = marke;
	}
}

public enum FahrzeugMarke { Audi, BMW, VW }