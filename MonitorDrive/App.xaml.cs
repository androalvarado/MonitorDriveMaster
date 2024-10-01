using MonitorDrive.Pages;
using MonitorDrive.Pages.Auth;

namespace MonitorDrive
{
    public partial class App : Application
    {
        
        public App()
        {

        InitializeComponent();

            // Crear una nueva NavigationPage
            var navigationPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromRgb(0x70, 0x3F, 0xF3), // Color de fondo de la barra
                BarTextColor = Color.FromHex("#FFFFFF") // Color del texto de la barra
            };

            // Establecer la MainPage
            MainPage = navigationPage;

            //Shell.Current.GoToAsync("MainPage");

        }
    }
}
