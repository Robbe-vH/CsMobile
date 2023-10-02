using MainApp.Models;
using System.Collections.ObjectModel;

namespace MainApp.Oefeningen;

public partial class ToDoPage : ContentPage
{
    ObservableCollection<ToDoItem> _taken = new ObservableCollection<ToDoItem>();
    public ToDoPage()
    {
		InitializeComponent();

        _taken.Add(new ToDoItem("Taak 1", false));
        _taken.Add(new ToDoItem("Taak 2", true));
        _taken.Add(new ToDoItem("Taak 3", false));

        takenColView.ItemsSource = _taken;
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        string tekst = await DisplayPromptAsync("New Item", "What do you need to do?");
        ToDoItem taak = new ToDoItem(tekst, false);
        _taken.Add(taak);
    }

    private void SwipeItem_Invoked_Done(object sender, EventArgs e)
    {
        SwipeItem item = (SwipeItem)sender;
        ToDoItem swipedToDo = (ToDoItem)item.CommandParameter;

        if (swipedToDo != null)
        {
            swipedToDo.IsKlaar = true;
        }
    }

    private void SwipeItem_Invoked_Delete(object sender, EventArgs e)
    {
        SwipeItem item = (SwipeItem)sender;
        ToDoItem swipedToDo = (ToDoItem)item.CommandParameter;

        if (swipedToDo != null)
        {
            _taken.Remove(swipedToDo);
        }
    }
}