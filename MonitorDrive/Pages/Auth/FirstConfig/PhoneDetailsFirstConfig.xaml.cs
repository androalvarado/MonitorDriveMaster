namespace MonitorDrive.Pages.Auth.FirstConfig;

public partial class PhoneDetailsFirstConfig : ContentPage
{
	public PhoneDetailsFirstConfig()
	{
		InitializeComponent();
	}

    private async void OnConfirmCliked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DashboardPage());

        // Eliminar la p�gina anterior de la pila de navegaci�n
        Navigation.RemovePage(this);
    }
}