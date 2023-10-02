using MainApp.Oefeningen;

namespace MainApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		var links = new List<OefeningLink>();

        links.Add(new OefeningLink("L33t Translator"));
        links.Add(new OefeningLink("To Do List"));
        links.Add(new OefeningLink("Calculator"));

        OefeningenCollectionView.ItemsSource = links;
    }

    private async void exerciseCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		if (e.CurrentSelection.FirstOrDefault() is OefeningLink selectedLink)
		{
			switch (selectedLink.Title)
			{
                case "L33t Translator":
                    await Shell.Current.GoToAsync(nameof(L33tTranslatorPage));
                    break;
                case "To Do List":
                    await Shell.Current.GoToAsync(nameof(ToDoPage));
                    break;
                case "Calculator":
                    await Shell.Current.GoToAsync(nameof(CalculatorPage));
                    break;
                default:
					break;
			}

            OefeningenCollectionView.SelectedItem = null;
        }
    }
}

