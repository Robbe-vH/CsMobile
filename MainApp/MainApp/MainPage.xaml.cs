namespace MainApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		var links = new List<OefeningLink>();

        links.Add(new OefeningLink("Oefening 1"));
        links.Add(new OefeningLink("Oefening 2"));
        links.Add(new OefeningLink("Oefening 3"));

        OefeningenCollectionView.ItemsSource = links;
    }

    private async void exerciseCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		if (e.CurrentSelection.FirstOrDefault() is OefeningLink selectedLink)
		{
			switch (selectedLink.Title)
			{
                case "Oefening 1":
                    await Shell.Current.GoToAsync(nameof(Oefening1Page));
                    break;
                case "Oefening 2":
                    await Shell.Current.GoToAsync(nameof(Oefening1Page));
                    break;
                case "Oefening 3":
                    await Shell.Current.GoToAsync(nameof(Oefening1Page));
                    break;
                default:
					break;
			}

            OefeningenCollectionView.SelectedItem = null;
        }
    }
}

