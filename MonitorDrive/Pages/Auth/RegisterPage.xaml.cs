using Microsoft.Maui.Controls;
using MonitorDrive.Pages.Auth.FirstConfig;
using MonitorDrive.ViewModels;
using System.Collections.ObjectModel;
namespace MonitorDrive.Pages.Auth;

public partial class RegisterPage : ContentPage
{
    private readonly UserViewModel user;
    public RegisterPage()
	{
		InitializeComponent();

        this.user = new UserViewModel();

        // Deshabilitar el TabBar
        Shell.SetTabBarIsVisible(this, false);
    }

    async private void OnRegister(object sender, EventArgs e)
    {
        // Navegar a la siguiente página
        await Navigation.PushAsync(new ProfileSettingsFirstConfig(user));

        Navigation.RemovePage(this);
    }
    async private void GoToLogin(object sender, EventArgs e)
    {
        // Navegar a la siguiente página
        await Navigation.PopAsync();

    }

}