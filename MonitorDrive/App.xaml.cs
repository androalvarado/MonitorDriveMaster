﻿using MonitorDrive.Pages;

namespace MonitorDrive
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
