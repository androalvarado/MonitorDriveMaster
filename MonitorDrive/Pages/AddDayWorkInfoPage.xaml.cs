namespace MonitorDrive.Pages;

public partial class AddDayWorkInfoPage : ContentPage
{
	public AddDayWorkInfoPage()
	{
		InitializeComponent();
	}
    private async void OnNavigateButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListInfoPage());
    }
}