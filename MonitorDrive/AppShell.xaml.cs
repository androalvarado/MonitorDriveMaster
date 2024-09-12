using MonitorDrive.Pages.ProfilePages;
using MonitorDrive.Pages;
namespace MonitorDrive

{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
            Routing.RegisterRoute(nameof(Pages.ProfilePages.ProfilePage), typeof(Pages.ProfilePages.ProfilePage));
            Routing.RegisterRoute(nameof(AddDayWorkInfoPage), typeof(AddDayWorkInfoPage));
        }
    }
}
