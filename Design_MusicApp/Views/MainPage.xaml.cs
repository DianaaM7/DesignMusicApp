namespace Design_MusicApp.Views;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnSongBarClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("SongPage");
    }
}

