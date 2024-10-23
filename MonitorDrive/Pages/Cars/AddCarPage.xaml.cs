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

    private void CarPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        Picker carPicker = (Picker)sender;
        string selectedCarType = carPicker.SelectedItem.ToString();
        // Hacer algo con la opción seleccionada (por ejemplo, mostrar un mensaje)
        //DisplayAlert("Carro seleccionado", $"Has seleccionado un carro {selectedCarType}", "OK");
    }

    private async void OnLabelTapped(object sender, TappedEventArgs e)
    {
        await DisplayAlert("Usage (%)", "Define the % of use in Uber", "OK");
    }
}