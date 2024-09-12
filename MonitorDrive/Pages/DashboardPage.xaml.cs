namespace MonitorDrive.Pages;
using Microsoft.Maui.Controls;
using MonitorDrive.Pages.ProfilePages;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}
    private void OnWordTapped(object sender, EventArgs e)
    {
        if (sender is Label tappedLabel)
        {
            // Reiniciar todos los labels a su estado original
            foreach (var child in ((StackLayout)tappedLabel.Parent).Children)
            {
                if (child is Label label)
                {
                    label.FontAttributes = FontAttributes.None;
                }
            }

            // Cambiar el FontAttribute del label tocado
            tappedLabel.FontAttributes = FontAttributes.Bold;

            // Cambiar el texto del label de destino
            labelIndicator.Text = tappedLabel.Text;

            // Ocultar o mostrar el grid
            labelStats.IsVisible = !labelStats.IsVisible;
        }

    }

    private async void OnNavigateButtonClicked(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new AddDayWorkInfoPage());
        await Shell.Current.GoToAsync("AddDayWorkInfoPage");
    }

    private void OnProfileImageTapped(object sender, EventArgs e)
    {
        TooltipFrame.IsVisible = !TooltipFrame.IsVisible;
    }

    private async void OnProfileTapped(object sender, EventArgs e)
    {
        TooltipFrame.IsVisible = false;
        //await Navigation.PushAsync(new ProfilePage());
        await Shell.Current.GoToAsync("ProfilePage");
    }
}