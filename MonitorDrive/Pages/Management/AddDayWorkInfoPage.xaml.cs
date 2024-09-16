namespace MonitorDrive.Pages.Management;

public partial class AddDayWorkInfoPage : ContentPage
{
	public AddDayWorkInfoPage()
	{
		InitializeComponent();

        // Deshabilitar el TabBar
        Shell.SetTabBarIsVisible(this, false);
    }

    private async void OnNavigateButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

}