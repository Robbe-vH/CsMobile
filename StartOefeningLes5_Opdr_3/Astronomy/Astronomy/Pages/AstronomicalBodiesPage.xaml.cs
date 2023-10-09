namespace Astronomy.Pages;

public partial class AstronomicalBodiesPage : ContentPage
{
	public AstronomicalBodiesPage()
	{
		InitializeComponent();

    }

    private async Task GoToBodydetails(string bodyname)
    {
        await Shell.Current.GoToAsync($"{nameof(AstronomicalBodyPage)}?bodyName={bodyname}");
    }

    public void AllBodies_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AstronomicalBodyPage) + "?bodyName=" + AllBodies.SelectedItem);
        AllBodies.SelectedItem = null;
    }

    private async void btnEarth_Clicked(object sender, EventArgs e)
    {
        GoToBodydetails("earth");
    }


    private void btnMoon_Clicked(object sender, EventArgs e)
    {
        GoToBodydetails("moon");
    }

    private void btnSun_Clicked(object sender, EventArgs e)
    {
        GoToBodydetails("sun");
    }

    private void btnComet_Clicked(object sender, EventArgs e)
    {
        GoToBodydetails("comet");
    }
}