using Microsoft.Maui.Controls;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MonitorDrive.Pages.Auth;

public partial class LoginPage : ContentPage
{
    public string UserId { get; set; }
    public string Password { get; set; }

    public LoginPage()
    {
        InitializeComponent();

        // Deshabilitar el TabBar
        Shell.SetTabBarIsVisible(this, false);

        BindingContext = this; // Configura el contexto de datos
    }

    async private void OnLogin(object sender, EventArgs e)
    {
        //Debug.WriteLine($"UserId: {UserId}, Password: {Password}"); // Para depuraci�n

        //if (string.IsNullOrWhiteSpace(UserId) || string.IsNullOrWhiteSpace(Password))
        //{
        //    await Application.Current.MainPage.DisplayAlert("Error", "Please enter your user ID and password.", "OK");
        //    return;
        //}

        //// L�gica de autenticaci�n (ejemplo simple)
        //if (UserId == "admin" && Password == "admin") // Cambia esto seg�n tu l�gica
        //{
        //    //await Application.Current.MainPage.DisplayAlert("Success", "Successful login.", "OK");
        //    // Navegar a la siguiente p�gina
        //    await Shell.Current.GoToAsync("///DashboardPage");
        //}
        //else
        //{
        //    await Application.Current.MainPage.DisplayAlert("Error", "Incorrect user ID or password.", "OK");
        //}

        await Navigation.PushAsync(new DashboardPage());

        // Eliminar la p�gina anterior de la pila de navegaci�n
            Navigation.RemovePage(this);
    }

    async private void GoToRegister(object sender, EventArgs e)
    {
        // Navegar a la siguiente p�gina
        //await Shell.Current.GoToAsync(nameof(RegisterPage));
        await Navigation.PushAsync(new RegisterPage());
    }
}