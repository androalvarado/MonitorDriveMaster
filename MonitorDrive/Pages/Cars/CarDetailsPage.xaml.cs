using MonitorDrive.ViewModels;

namespace MonitorDrive.Pages.Cars;

public partial class CarDetailsPage : ContentPage
{    
    public CarDetailsPage(CarViewModel car)
    {
        InitializeComponent();
        BindingContext = new CarDetailsViewModel(car);
    }

    private void OnFilterButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        SelectButton(button);

        // Lógica para mostrar/ocultar los frames según el botón seleccionado
        if (button == DetailsButton)
        {
            CarDetailsFrame.IsVisible = true;
            CarMaintenanceFrame.IsVisible = false;
            CarExpensivesFrame.IsVisible = false;
        }
        else if (button == MaintenanceButton)
        {
            CarDetailsFrame.IsVisible = false;
            CarMaintenanceFrame.IsVisible = true;
            CarExpensivesFrame.IsVisible = false;
        }
        else if (button == ExpensivesButton)
        {
            CarDetailsFrame.IsVisible = false;
            CarMaintenanceFrame.IsVisible = false;
            CarExpensivesFrame.IsVisible = true;
        }
    }

    private void SelectButton(Button selectedButton)
    {
        string primaryColor = "#B69CFA";

        // Restablecer todos los botones a su estado original
        DetailsButton.BackgroundColor = Colors.Transparent;
        MaintenanceButton.BackgroundColor = Colors.Transparent;
        ExpensivesButton.BackgroundColor = Colors.Transparent;

        // Cambiar el color del botón seleccionado
        selectedButton.BackgroundColor = Color.FromArgb(primaryColor);
        selectedButton.TextColor = Colors.White;
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnEditClicked(object sender, EventArgs e)
    {
        //await Navigation.PushModalAsync(new CarDetailsPage());
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