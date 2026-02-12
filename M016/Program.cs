namespace M016;

internal class Program
{
	static void Main(string[] args)
	{
		List<int> zahlen = Enumerable.Range(0, 20).ToList();

		zahlen.Where(e => e % 3 == 0); //Finde alle Zahlen, die durch 3 teilbar sind

		Console.WriteLine(zahlen.Sum());
		Console.WriteLine(zahlen.Average());
		Console.WriteLine(zahlen.Min());
		Console.WriteLine(zahlen.Max());

		Console.WriteLine(zahlen.First());
		Console.WriteLine(zahlen.Last());

		//Console.WriteLine(zahlen.First(e => e > 100)); //Sequence contains no matching element
		Console.WriteLine(zahlen.FirstOrDefault(e => e > 100)); //default(int)

		List<Fahrzeug> fahrzeuge =
		[
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		];

		//Finde alle VWs
		fahrzeuge.Where(e => e.Marke == FahrzeugMarke.VW);

		//Finde alle VWs die mind. 250km/h fahren können
		fahrzeuge.Where(e => e.Marke == FahrzeugMarke.VW && e.MaxV >= 250);
		fahrzeuge.Where(e => e.Marke == FahrzeugMarke.VW).Where(e => e.MaxV >= 250);

		//OrderBy
		//Nach Marke sortieren
		fahrzeuge.OrderBy(e => e.Marke);

		//Subsequente Sortierung(en)
		fahrzeuge.OrderBy(e => e.Marke).ThenBy(e => e.MaxV);

		//All und Any

		//All: Prüft ob alle Elemente einer Bedingung entsprechen
		if (fahrzeuge.All(e => e.MaxV >= 250))
		{
			//...
		}

		string text = "Hallo Welt";
		if (text.All(char.IsLetter))
		{

		}

		//Any: Prüft ob mind. ein Element der Bedingung entspricht
		fahrzeuge.Any(); //Prüft, ob die Liste leer ist

		//Count
		fahrzeuge.Where(e => e.Marke == FahrzeugMarke.VW).Count(); //Wieviele VWs haben wir?
		fahrzeuge.Count(e => e.Marke == FahrzeugMarke.VW);

		//Average, Sum, Min, Max, MinBy, MaxBy
		fahrzeuge.Average(e => e.MaxV); //208.41666666

		fahrzeuge.Min(e => e.MaxV); //Zahl: 125
		fahrzeuge.MinBy(e => e.MaxV); //Objekt: Fahrzeug(125, Audi)

		//Skip & Take
		int page = 0;
		fahrzeuge.Skip(page * 10).Take(10); //Webshop

		//Finde die 3 schnellsten Fahrzeuge
		fahrzeuge.OrderByDescending(e => e.MaxV).Take(3);

		//////////////////////////////////////////////////////////////////////////////////////

		//Erweiterungsmethoden
		int zahl = 123;
		zahl.Quersumme();

		Console.WriteLine(3578.Quersumme());

		//Vom Compiler generiert:
		ExtensionMethods.Quersumme(zahl);
		Enumerable.Where(fahrzeuge, e => e.Marke == FahrzeugMarke.VW);
	}
}

public static class ExtensionMethods
{
	public static int Quersumme(this int x)
	{
		return (int) x.ToString().Sum(e => char.GetNumericValue(e));
	}
}