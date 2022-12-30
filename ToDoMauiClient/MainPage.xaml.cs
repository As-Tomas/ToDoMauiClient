using Microsoft.Maui.Controls.Compatibility.Platform.UWP;
using System.Diagnostics;
using ToDoMauiClient.DataServices;
using Windows.Graphics.Display;

namespace ToDoMauiClient;

public partial class MainPage : ContentPage
{
    private readonly IRestDataService _dataService;

    public MainPage(IRestDataService dataService)
	{
		InitializeComponent();

		_dataService = dataService;
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();

		collectionView.ItemsSource = await _dataService.GetAllToDosAsync();
	}

	async void OnAddToDoClicked(object sender, EventArgs e)
	{
		Debug.WriteLine("--> add button clicked");
	}

	async void OnSelectioChanged(object sender, SelectionChangedEventArgs e)
	{
        Debug.WriteLine("--> Item change clicked");
    }

}

