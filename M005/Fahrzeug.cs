namespace M005;

public class Fahrzeug
{
	public int MaxV { get; set; }

	public FahrzeugMarke Marke { get; set; }

	public Fahrzeug(int maxV, FahrzeugMarke marke)
	{
		MaxV = maxV;
		Marke = marke;
	}

	public override string ToString()
	{
		return $"Geschwindigkeit: {MaxV}, Marke: {Marke}";
	}
}

public enum FahrzeugMarke { Audi, BMW, VW }