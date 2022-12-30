using ToDoMauiClient.DataServices;
using ToDoMauiClient.Models;

namespace ToDoMauiClient.Pages;

public partial class ManageToDoPage : ContentPage
{
    private readonly IRestDataService _dataService;
	ToDo _toDo;
	bool _isNew;

	public ToDo ToDO
	{
		get => _toDo;
		set
		{
			_isNew = IsNew(value);
			_toDo = value;
			OnPropertyChanged();
		}
	}

    public ManageToDoPage(IRestDataService dataService)
	{
		InitializeComponent();

		_dataService = dataService;
		BindingContext = this;
	}

	bool IsNew(ToDo toDo)
	{
		if (toDo.Id == 0)
			return true;
		return false;
	}
}