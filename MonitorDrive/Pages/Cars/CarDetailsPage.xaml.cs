using MonitorDrive.ViewModels;

namespace MonitorDrive.Pages.Cars;

public partial class CarDetailsPage : ContentPage
{    
    public CarDetailsPage(CarViewModel car)
    {
        InitializeComponent();
        BindingContext = new CarDetailsViewModel(car);
    }
    
    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnEditClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var car = button?.CommandParameter as CarViewModel;

        if (car != null)
        {
            // Navegar a la página de detalles
            await Navigation.PushModalAsync(new CarDetailsPage(car));
        }
    }

    private async void OnTiresDetailsCliked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TiresDetailsPage());
    }

    private async void OnMaintenancesButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CarMaintenancesListPage());
    }

    private async void OnExpensivesButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ExtraExpensivesListPage());
    }
}