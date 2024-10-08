﻿using  MonitorDrive.Pages.Auth;

namespace MonitorDrive
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Deshabilitar el TabBar
            Shell.SetTabBarIsVisible(this, false);
        }

        async private void GoToRegister(object sender, EventArgs e)
        {

            // Desactivar el botón para evitar múltiples clics
            //((Button)sender).IsEnabled = false;

            // Animación de salida
            //await this.FadeTo(0, 200);

            // Preparar AppShell
            //App.AppShellInstance.Opacity = 0;
            //Application.Current.MainPage = App.AppShellInstance;

            //// Animar la aparición del AppShell
            //await App.AppShellInstance.FadeTo(1, 200);

            // Navegar explícitamente a Register
            //await Shell.Current.GoToAsync(nameof(RegisterPage));

            await Navigation.PushAsync(new RegisterPage());
            // Eliminar la página anterior de la pila de navegación
            Navigation.RemovePage(this);
        }
        async private void GoToLogin(object sender, EventArgs e)
        {

            // Desactivar el botón para evitar múltiples clics
            //((Button)sender).IsEnabled = false;

            // Preparar AppShell
            //App.AppShellInstance.Opacity = 0;
            //Application.Current.MainPage = App.AppShellInstance;

            // Navegar explícitamente a Register
            //await Shell.Current.GoToAsync($"{nameof(LoginPage)}");
            await Navigation.PushAsync(new LoginPage());

            // Eliminar la página anterior de la pila de navegación
            Navigation.RemovePage(this);

        }

    }

}
