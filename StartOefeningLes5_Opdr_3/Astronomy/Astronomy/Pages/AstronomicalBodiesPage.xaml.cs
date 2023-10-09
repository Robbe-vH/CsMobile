namespace Astronomy.Pages;

public partial class AstronomicalBodiesPage : ContentPage
{
	public AstronomicalBodiesPage()
	{
		InitializeComponent();

    }

    private async void btnEarth_Clicked(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync("astronomicalBody", typeof(AstronomicalBodyPage));
    }
}