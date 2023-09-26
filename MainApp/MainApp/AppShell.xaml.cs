namespace MainApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(Oefening1Page), typeof(Oefening1Page));
	}
}
