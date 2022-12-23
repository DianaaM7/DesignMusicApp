using Design_MusicApp.Views;

namespace Design_MusicApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(SongPage), typeof(SongPage));
        
    }
}
