using MainApp.Oefeningen;

namespace MainApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(L33tTranslatorPage), typeof(L33tTranslatorPage));
		Routing.RegisterRoute(nameof(ToDoPage), typeof(ToDoPage));
	}
}
