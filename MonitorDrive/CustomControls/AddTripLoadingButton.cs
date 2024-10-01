using MonitorDrive.Pages.Management;

namespace MonitorDrive.CustomControls
{
    public partial class AddTripLoadingButton : ContentView
    {
        private Button button;
        private ActivityIndicator activityIndicator;
        private new INavigation Navigation { get; set; }

        public AddTripLoadingButton()
        { }

            public AddTripLoadingButton(INavigation navigation)
        {
            Navigation = navigation;

            button = new Button
            {
                Text = "Add Trip",
                BackgroundColor = Color.FromRgb(0x70, 0x3F, 0xF3),
                TextColor = Color.FromRgb(255, 255, 255), // Color blanco en RGB
                CornerRadius = 5
            };

            activityIndicator = new ActivityIndicator
            {
                IsRunning = false,
                IsVisible = false,
                Color = Color.FromRgb(255, 255, 255)
            };

            button.Clicked += Button_Clicked;

            Content = new Grid
            {
                Children =
                {
                    button,
                    activityIndicator
                }
            };
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Mostrar indicador de actividad y deshabilitar el botón
            activityIndicator.IsRunning = true;
            activityIndicator.IsVisible = true;
            button.IsEnabled = false;

            // Redirigir a la página
            await Navigation.PushAsync(new AddDayWorkInfoPage());

            // Ocultar indicador de actividad y habilitar el botón nuevamente
            activityIndicator.IsRunning = false;
            activityIndicator.IsVisible = false;
            button.IsEnabled = true;
        }
    }
}
