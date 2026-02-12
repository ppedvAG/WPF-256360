using System.Diagnostics;

namespace M013.Model;

[DebuggerDisplay("Person - ID: {ID}, Vorname: {Vorname}, Nachname: {Nachname}, GebDat: {Geburtsdatum.ToString(\"yyyy.MM.dd\")}, Alter: {Alter}, " +
	"Jobtitel: {Job.Titel}, Gehalt: {Job.Gehalt}, Einstellungsdatum: {Job.Einstellungsdatum.ToString(\"yyyy.MM.dd\")}")]
public record Person(int ID, string Vorname, string Nachname, DateTime Geburtsdatum, int Alter, Beruf Job, List<string> Hobbies);
