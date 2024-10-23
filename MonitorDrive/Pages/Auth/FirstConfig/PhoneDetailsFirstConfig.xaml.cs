using MonitorDrive.Pages.Cars;
using MonitorDrive.ViewModels;

namespace MonitorDrive.Pages.Auth.FirstConfig;

public partial class PhoneDetailsFirstConfig : ContentPage
{
    private readonly UserViewModel user;
    public PhoneDetailsFirstConfig(UserViewModel user)
	{
		InitializeComponent();
        this.user = user;
	}

    private async void OnConfirmCliked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CarsListPage(user));

        // Eliminar la página anterior de la pila de navegación
        Navigation.RemovePage(this);
    }

    private async void OnLabelTapped(object sender, TappedEventArgs e)
    {
        await DisplayAlert("Usage (%)", "Define the % of use in Uber", "OK");
    }
}