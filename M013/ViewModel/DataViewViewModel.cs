using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using M013.Model;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

namespace M013.ViewModel;

/// <summary>
/// MVVM Toolkit
/// 
/// NuGet: CommunityToolkit.Mvvm
/// 
/// Basisklasse immer ObservableObject
/// </summary>
public partial class DataViewViewModel : ObservableObject
{
	[ObservableProperty]
	private ObservableCollection<Person> personen;

	[ObservableProperty]
	private Person selected;

	[RelayCommand]
	public void DeletePerson(object o)
	{
		Personen.Remove(Selected);
	}

	public DataViewViewModel()
	{
		string readJson = File.ReadAllText(@"..\..\..\Personen.json");
		Personen = new ObservableCollection<Person>(JsonSerializer.Deserialize<List<Person>>(readJson)!);
	}
}