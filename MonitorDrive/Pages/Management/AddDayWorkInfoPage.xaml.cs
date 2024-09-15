using Microsoft.Maui.Controls;
namespace MonitorDrive.Pages.Management;

public partial class AddDayWorkInfoPage : ContentPage
{
	public AddDayWorkInfoPage()
	{
		InitializeComponent();
	}

    async private void OnNavigateButtonClicked(object sender, EventArgs e)
{
    // Navegar a la siguiente página
    await Shell.Current.GoToAsync(nameof(ListInfoPage));
}
}