using MonitorDrive.ViewModels;

namespace MonitorDrive.Pages.Auth.FirstConfig;

public partial class ProfileSettingsFirstConfig : ContentPage
{
    private readonly UserViewModel user;
    public ProfileSettingsFirstConfig(UserViewModel user)
	{
		InitializeComponent();
        this.user = user;
	}

    private async void OnConfirmCliked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PhoneDetailsFirstConfig(user));

        Navigation.RemovePage(this);
    }
}