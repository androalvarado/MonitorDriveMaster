namespace MonitorDrive.Pages.Cars;

public partial class ExtraExpensivesListPage : ContentPage
{
	public ExtraExpensivesListPage()
	{
		InitializeComponent();
	}

    private async void OnCancelButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}