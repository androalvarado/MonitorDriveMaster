namespace MonitorDrive.Pages;
using Microsoft.Maui.Controls;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}
    private void OnWordTapped(object sender, EventArgs e)
    {
        var label = sender as Label;
        if (label != null)
        {
            label.FontAttributes = label.FontAttributes == FontAttributes.Bold ? FontAttributes.None : FontAttributes.Bold;
        }
    }

    private async void OnNavigateButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddDayWorkInfoPage());
    }
}