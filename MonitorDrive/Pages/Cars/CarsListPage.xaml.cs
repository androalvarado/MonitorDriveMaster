using MonitorDrive.Pages.ProfilePages;
using MonitorDrive.ViewModels;

namespace MonitorDrive.Pages.Cars;

public partial class CarsListPage : ContentPage
{
    public CarViewModel DataContext { get; private set; }

    private readonly UserViewModel user;

    public CarsListPage(UserViewModel user)
	{
		InitializeComponent();

        this.user = user;

        DataContext = new CarViewModel(); // Inicialización vacía
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new ProfilePage(user));

        Navigation.RemovePage(this);
    }

    private async void OnAddClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddCarPage());
    }

    private async void OnDetailsButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var car = button?.CommandParameter as CarViewModel;

        if (car != null)
        {
            // Navegar a la página de detalles
            await Navigation.PushAsync(new CarDetailsPage(car));
        }
    }
}