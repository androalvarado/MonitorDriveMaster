using CommunityToolkit.Maui.Views;
using MonitorDrive.Pages.Cars.CarPopupPages;
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
        await Navigation.PushModalAsync(new AddCarPage());
    }

    private async void OnTiresDetailsCliked(object sender, EventArgs e)
    {
        await this.ShowPopupAsync(new AddTiresPopup());
    }

    private async void OnMaintenancesButtonClicked(object sender, EventArgs e)
    {
        await this.ShowPopupAsync(new AddMaintenancePopup());

    }

    private  async void OnExtraDetailsCliked(object sender, EventArgs e)
    {
        await this.ShowPopupAsync(new AddExtraExpensePopup());
    }

    private async void OnPaymentCliked(object sender, EventArgs e)
    {
        await this.ShowPopupAsync(new AddCarPaymentPopup());
    }
}