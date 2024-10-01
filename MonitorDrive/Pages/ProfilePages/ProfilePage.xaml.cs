using MonitorDrive;
using MonitorDrive.Pages.ProfilePages;
using System.Globalization;
using Microsoft.Maui.Controls;
using MonitorDrive.ViewModels;
using MonitorDrive.Pages.Cars;
using MonitorDrive.Pages.CellPhones;
namespace MonitorDrive.Pages.ProfilePages;

public partial class ProfilePage : ContentPage
{
    private readonly UserViewModel user;
    public ProfilePage(UserViewModel user)
    {
        InitializeComponent();

        this.user = user;

        // Establecer el índice seleccionado por defecto (0 para ENG)
        LanguagePicker.SelectedIndex = 1; // Cambia el índice según tu preferencia
    }

    private async void OnEditProfileTapped(object sender, EventArgs e)
    {
        // Animación de escala al tocar el botón
        await EditButton.ScaleTo(0.9, 50, Easing.Linear);
        await EditButton.ScaleTo(1, 50, Easing.Linear);

        
        // Navegar a la página de detalles
        await Navigation.PushModalAsync(new EditProfileDetailsPage(user));
      
        // Navegar a la página de edición de perfil        
        //await Navigation.PushModalAsync(new EditProfileDetailsPage(this.user));       
    }

    private async void OnPhonesLabelTapped(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new PhonesListPage());
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

    private void OnLabelTapped(object sender, EventArgs e)
    {
        Label tappedLabel = sender as Label;

        // Restablecer el color de todos los Labels
        InfoLabel.TextColor = Color.FromRgb(172, 153, 234);
        SettingsLabel.TextColor = Color.FromRgb(172, 153, 234);

        // Cambiar el color del texto del Label presionado
        if (tappedLabel == InfoLabel)
        {
            InfoSection.IsVisible = true;
            SettingsSection.IsVisible = false;            
            InfoLabel.TextColor = Color.FromRgb(0x70, 0x3F, 0xF3); // Cambiar color al presionar InfoLabel
        }
        else if (tappedLabel == SettingsLabel)
        {
            InfoSection.IsVisible = false;
            SettingsSection.IsVisible = true;
            SettingsLabel.TextColor = Color.FromRgb(0x70, 0x3F, 0xF3); // Cambiar a coloral presionar SettingsLabel
        }
    }

}