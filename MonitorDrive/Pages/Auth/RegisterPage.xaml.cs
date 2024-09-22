using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
namespace MonitorDrive.Pages.Auth;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();

        // Deshabilitar el TabBar
        Shell.SetTabBarIsVisible(this, false);
    }

    async private void OnRegister(object sender, EventArgs e)
    {
        // Navegar a la siguiente página
        //await Shell.Current.GoToAsync(nameof(LoginPage));
        await Navigation.PushAsync(new LoginPage());
    }
    async private void GoToLogin(object sender, EventArgs e)
    {
        // Navegar a la siguiente página
        //await Shell.Current.GoToAsync(nameof(LoginPage));
        await Navigation.PopAsync();

    }

}