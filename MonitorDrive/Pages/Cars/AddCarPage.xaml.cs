namespace MonitorDrive.Pages.Cars;

public partial class AddCarPage : ContentPage
{
	public AddCarPage()
	{
		InitializeComponent();
	}

    

    private async  void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void OnConfirmClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private void OnSelectPhotoClicked(object sender, EventArgs e)
    {

    }
}