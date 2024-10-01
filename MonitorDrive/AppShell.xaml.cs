using MonitorDrive.Pages;
using MonitorDrive.Pages.Auth;
using MonitorDrive.Pages.ProfilePages;
using MonitorDrive.Pages.Masters;
using MonitorDrive.Pages.Management;
using Microsoft.Maui.Controls;
using MonitorDrive.Pages.CellPhones;

namespace MonitorDrive

{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //MainPageTab.IsVisible = false;

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

            Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
                        
            Routing.RegisterRoute(nameof(ListInfoPage), typeof(Pages.Management.ListInfoPage));
            Routing.RegisterRoute(nameof(AddDayWorkInfoPage), typeof(Pages.Management.AddDayWorkInfoPage));

            Routing.RegisterRoute(nameof(MonitorMasterPage), typeof(Pages.Masters.MonitorMasterPage));

            Routing.RegisterRoute(nameof(EditProfileDetailsPage), typeof(Pages.ProfilePages.EditProfileDetailsPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(Pages.ProfilePages.ProfilePage));

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(Pages.Auth.LoginPage));
            Routing.RegisterRoute(nameof(RegisterPage), typeof(Pages.Auth.RegisterPage));


        }

    }
}
