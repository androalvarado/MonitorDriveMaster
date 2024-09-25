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
            // Animaci�n de escala al tocar el bot�n
            await CircularButton.ScaleTo(0.9, 50, Easing.Linear);
            await CircularButton.ScaleTo(1, 50, Easing.Linear);

            // Aqu� puedes agregar la l�gica que deseas ejecutar cuando se toca el bot�n
            // Navegar a la siguiente p�gina
            //await Shell.Current.GoToAsync(nameof(AddDayWorkInfoPage));
            await Navigation.PushAsync(new AddDayWorkInfoPage());

        }

    }
};

