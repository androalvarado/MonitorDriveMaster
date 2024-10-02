using MonitorDrive.ViewModels;

namespace MonitorDrive.Pages.Auth.FirstConfig;

public partial class ProfileSettingsFirstConfig : ContentPage
{
    private readonly UserViewModel user;
    public ProfileSettingsFirstConfig(UserViewModel user)
	{
		InitializeComponent();
        CargarPaises();
        this.user = user;
	}

    private async void OnConfirmCliked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PhoneDetailsFirstConfig(user));

        Navigation.RemovePage(this);
    }

    private void CargarPaises()
    {
        var paises = new List<string>
            {
                "Argentina",
                "Bolivia",
                "Brasil",
                "Canad�",
                "Chile",
                "Colombia",
                "Costa Rica",
                "Cuba",
                "Ecuador",
                "El Salvador",
                "Estados Unidos",
                "Guatemala",
                "Hait�",
                "Honduras",
                "Jamaica",
                "M�xico",
                "Nicaragua",
                "Panam�",
                "Paraguay",
                "Per�",
                "Rep�blica Dominicana",
                "Uruguay",
                "Venezuela"
            };

        pickerPaises.ItemsSource = paises;
    }

    private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        var paisSeleccionado = (string)picker.SelectedItem;
        // Realiza alguna acci�n con el pa�s seleccionado
    }
}