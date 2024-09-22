using MonitorDrive;
using MonitorDrive.Pages.ProfilePages;
using System.Globalization;
using Microsoft.Maui.Controls;
using MonitorDrive.ViewModels;
using MonitorDrive.Pages.Cars;
namespace MonitorDrive.Pages.ProfilePages;

public partial class ProfilePage : ContentPage
{
    private readonly UserViewModel user;
    public ProfilePage(UserViewModel user)
    {
        InitializeComponent();

        this.user = user;

        // Establecer el �ndice seleccionado por defecto (0 para ENG)
        LanguagePicker.SelectedIndex = 1; // Cambia el �ndice seg�n tu preferencia
    }

    private async void OnEditProfileTapped(object sender, EventArgs e)
    {
        // Animaci�n de escala al tocar el bot�n
        await EditButton.ScaleTo(0.9, 50, Easing.Linear);
        await EditButton.ScaleTo(1, 50, Easing.Linear);

        // Navegar a la p�gina de edici�n de perfil        
        await Navigation.PushModalAsync(new EditProfileDetailsPage(this.user));       
    }

    private async void OnPhonesLabelTapped(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new PhoneSettingsPage());
    }

    private async void OnCarsTapped(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new CarsListPage());
    }

    private void OnLanguageChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        var selectedLanguage = picker.SelectedIndex;

        if (selectedLanguage != -1)
        {
            // Cambia el idioma de la aplicaci�n
            string cultureCode = selectedLanguage switch
            {
                0 => "es", // Espa�ol
                1 => "en", // Ingl�s
                2 => "fr", // Franc�s
                _ => "en", // Por defecto Ingles
            };

            CultureInfo culture = new CultureInfo(cultureCode);
            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;

        }
    }

    private void OnInfoLabelTapped(object sender, TappedEventArgs e)
    {
        InfoSection.IsVisible = true;
        SettingsSection.IsVisible = false;
    }

    private void OnSettingsLabelTapped(object sender, TappedEventArgs e)
    {
        InfoSection.IsVisible = false;
        SettingsSection.IsVisible = true;
    }

}