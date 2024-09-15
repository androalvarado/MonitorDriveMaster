using MonitorDrive;
using MonitorDrive.Pages.ProfilePages;
using System.Globalization;
using Microsoft.Maui.Controls;
namespace MonitorDrive.Pages.ProfilePages;

public partial class ProfilePage : ContentPage
{
   
    public ProfilePage()
    {
        InitializeComponent();

        // Establecer el índice seleccionado por defecto (0 para Español)
        LanguagePicker.SelectedIndex = 1; // Cambia el índice según tu preferencia
    }

    private async void OnNavigateButtonClicked(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new AddDayWorkInfoPage());
        //await Shell.Current.GoToAsync(nameof(DashboardPage));
    }

    private async void OnRankTapped(object sender, EventArgs e)
    {
        // Navegar a RankingPage
        await Shell.Current.GoToAsync(nameof(RankingPage));
    }

    private void OnLanguageChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        var selectedLanguage = picker.SelectedIndex;

        if (selectedLanguage != -1)
        {
            // Cambia el idioma de la aplicación
            string cultureCode = selectedLanguage switch
            {
                0 => "es", // Español
                1 => "en", // Inglés
                2 => "fr", // Francés
                _ => "en", // Por defecto Ingles
            };

            CultureInfo culture = new CultureInfo(cultureCode);
            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;

        }
    }

}