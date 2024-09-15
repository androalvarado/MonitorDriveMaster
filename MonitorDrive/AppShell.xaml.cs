﻿using MonitorDrive.Pages;
using MonitorDrive.Pages.Auth;
using MonitorDrive.Pages.ProfilePages;
using MonitorDrive.Pages.Management;

namespace MonitorDrive

{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

            Routing.RegisterRoute(nameof(DashboardPage), typeof(Pages.DashboardPage));

            Routing.RegisterRoute(nameof(AddDayWorkInfoPage), typeof(Pages.Management.AddDayWorkInfoPage));
            Routing.RegisterRoute(nameof(ListInfoPage), typeof(Pages.Management.ListInfoPage));


            Routing.RegisterRoute(nameof(RankingPage), typeof(Pages.ProfilePages.RankingPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(Pages.ProfilePages.ProfilePage));
            
            
            Routing.RegisterRoute(nameof(LoginPage), typeof(Pages.Auth.LoginPage));
            Routing.RegisterRoute(nameof(RegisterPage), typeof(Pages.Auth.RegisterPage));


        }
    }
}
