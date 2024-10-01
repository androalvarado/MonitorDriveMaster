namespace MonitorDrive.Pages.Auth.FirstConfig;

public partial class ProfileSettingsFirstConfig : ContentPage
{
	public ProfileSettingsFirstConfig()
	{
		InitializeComponent();
	}

    private async void OnConfirmCliked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PhoneDetailsFirstConfig());
    }
}