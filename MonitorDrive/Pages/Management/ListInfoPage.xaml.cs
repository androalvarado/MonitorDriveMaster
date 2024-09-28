using MonitorDrive.Pages;
using MonitorDrive.ViewModels;
namespace MonitorDrive.Pages.Management
{ 
    public partial class ListInfoPage : ContentPage
{
        public TravelViewModel DataContext { get; private set; }

        public ListInfoPage()
	{
		InitializeComponent();

            //BindingContext = new TravelViewModel();

            // Deshabilitar el TabBar
            //Shell.SetTabBarIsVisible(this, false);
        }
        
        private async void OnCircularButtonTapped(object sender, EventArgs e)
        {
            // Animación de escala al tocar el botón
            await CircularButton.ScaleTo(0.9, 50, Easing.Linear);
            await CircularButton.ScaleTo(1, 50, Easing.Linear);

            await Navigation.PushAsync(new AddDayWorkInfoPage());

        }

    }
};

