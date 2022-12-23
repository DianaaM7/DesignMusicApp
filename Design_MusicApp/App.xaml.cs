using Design_MusicApp.Views;

namespace Design_MusicApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

	}
}
