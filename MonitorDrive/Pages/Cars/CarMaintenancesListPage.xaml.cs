namespace MonitorDrive.Pages.Cars;

public partial class CarMaintenancesListPage : ContentPage
{
	public CarMaintenancesListPage()
	{
		InitializeComponent();
	}

    private async void OnCancelButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}