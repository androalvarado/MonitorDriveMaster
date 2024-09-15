using MonitorDrive.Pages;
using MonitorDrive.Pages.Auth;

namespace MonitorDrive
{
    public partial class App : Application
    {
        
        public App()
        {

        InitializeComponent();

            // Iniciar con StartupPage
            MainPage = new AppShell();

            Shell.Current.GoToAsync("MainPage");
            
        }
    }
}
