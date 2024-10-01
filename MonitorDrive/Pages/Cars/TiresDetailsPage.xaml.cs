namespace MonitorDrive.Pages.Cars;

public partial class TiresDetailsPage : ContentPage
{
	public TiresDetailsPage()
	{
		InitializeComponent();
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void OnNewClicked(object sender, EventArgs e)
    {
        //await Navigation.PushModalAsync(new CarDetailsPage());
        await Navigation.PopModalAsync();
    }
}