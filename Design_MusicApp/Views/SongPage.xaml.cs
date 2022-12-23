namespace Design_MusicApp.Views;

public partial class SongPage : ContentPage
{
	public SongPage()
	{
		InitializeComponent();

	}

    private async void OnDownClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}