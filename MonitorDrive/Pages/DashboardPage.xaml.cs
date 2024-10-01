namespace MonitorDrive.Pages;

using CommunityToolkit.Maui.Views;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using MonitorDrive.Pages.Auth;
using MonitorDrive.Pages.Expenses;
using MonitorDrive.Pages.Management;
using MonitorDrive.Pages.ProfilePages;
using System.Reflection;

public partial class DashboardPage : ContentPage
{
    public DashboardPage()
	{
		InitializeComponent();

        //BindingContext = this;
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
            ProfitabilityStats.IsVisible = !ProfitabilityStats.IsVisible;
        }

    }

    private async void OnAddInfoButtonClicked(object sender, EventArgs e)
    {
        AddInfoButton.IsVisible = false;
        AddTripLoadingButton.IsVisible = true;

        // Animación de escala al tocar el botón
        await AddInfoButton.ScaleTo(0.9, 50, Easing.Linear);
        await AddInfoButton.ScaleTo(1, 50, Easing.Linear);

        await Navigation.PushAsync(new AddDayWorkInfoPage());

        AddInfoButton.IsVisible = !AddInfoButton.IsVisible;
        AddTripLoadingButton.IsVisible = !AddTripLoadingButton.IsVisible;
    }

    private async void OnAddExpensiveButtonClicked(object sender, EventArgs e)
    {
        await AddExpensiveButton.ScaleTo(0.9, 50, Easing.Linear);
        await AddExpensiveButton.ScaleTo(1, 50, Easing.Linear);

        AddExpensiveButton.IsVisible = false;
        AddExpensiveLoadingButton.IsVisible = true;

        await this.ShowPopupAsync(new AddExpensePopup());

        AddExpensiveButton.IsVisible = !AddExpensiveButton.IsVisible;
        AddExpensiveLoadingButton.IsVisible = !AddExpensiveLoadingButton.IsVisible;
    }

    private void OnProfileImageTapped(object sender, EventArgs e)
    {
        TooltipFrame.IsVisible = !TooltipFrame.IsVisible;
    }

    private async void OnLogOutTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());

        // Eliminar la página anterior de la pila de navegación
        Navigation.RemovePage(this);
    }
}