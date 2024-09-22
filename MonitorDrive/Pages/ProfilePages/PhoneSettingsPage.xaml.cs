namespace MonitorDrive.Pages.ProfilePages;

public partial class PhoneSettingsPage : ContentPage
{
	public PhoneSettingsPage()
	{
		InitializeComponent();

        // Deshabilitar el TabBar
        Shell.SetTabBarIsVisible(this, false);
    }
}