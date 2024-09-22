using MonitorDrive.Pages;
namespace MonitorDrive.Pages.Management
{ 
    public partial class ListInfoPage : ContentPage
{
	public ListInfoPage()
	{
		InitializeComponent();

        // Deshabilitar el TabBar
        //Shell.SetTabBarIsVisible(this, false);
    }
        
        private async void OnCircularButtonTapped(object sender, EventArgs e)
        {
            // Animación de escala al tocar el botón
            await CircularButton.ScaleTo(0.9, 50, Easing.Linear);
            await CircularButton.ScaleTo(1, 50, Easing.Linear);

            // Aquí puedes agregar la lógica que deseas ejecutar cuando se toca el botón
            // Navegar a la siguiente página
            //await Shell.Current.GoToAsync(nameof(AddDayWorkInfoPage));
            await Navigation.PushAsync(new AddDayWorkInfoPage());

        }

    }
};

