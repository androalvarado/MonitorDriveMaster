using MonitorDrive.ViewModels;

namespace MonitorDrive.Pages.Cars;

public partial class CarsListPage : ContentPage
{
    public CarViewModel DataContext { get; private set; }

    public CarsListPage()
	{
		InitializeComponent();

        DataContext = new CarViewModel(); // Inicializaci�n vac�a
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnAddClicked(object sender, EventArgs e)
    {
        //await Navigation.PushModalAsync(new CarDetailsPage());
    }

    private async void OnDetailsButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var car = button?.CommandParameter as CarViewModel;

        if (car != null)
        {
            // Navegar a la p�gina de detalles
            await Navigation.PushAsync(new CarDetailsPage(car));
        }
    }
}