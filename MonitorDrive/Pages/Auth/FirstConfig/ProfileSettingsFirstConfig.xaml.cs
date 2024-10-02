using MonitorDrive.ViewModels;
using System.Linq;

namespace MonitorDrive.Pages.Auth.FirstConfig;

public partial class ProfileSettingsFirstConfig : ContentPage
{
    private readonly UserViewModel user;

    public class CountryInfo
    {
        public required string Country { get; set; }
        public required string Currency { get; set; }
        public required string Language { get; set; }

        public override string ToString()
        {
            return Country; // Para mostrar solo el nombre del país en el Picker
        }
    }

    private List<CountryInfo> paises;

    public ProfileSettingsFirstConfig(UserViewModel user)
	{
		InitializeComponent();
        UploadCountry();
        this.user = user;
	}

    private async void OnConfirmCliked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PhoneDetailsFirstConfig(user));

        Navigation.RemovePage(this);
    }

    private void UploadCountry()
    {
        paises = new List<CountryInfo>
            {
                new CountryInfo { Country = "Argentina", Currency = "ARS", Language = "ESP" },
                new CountryInfo { Country = "Bolivia", Currency = "BOB", Language = "ESP, QUE, AYM" },
                new CountryInfo { Country = "Brasil", Currency = "BRL", Language = "POR" },
                new CountryInfo { Country = "Canadá", Currency = "CAD", Language = "ENG, FR" },
                new CountryInfo { Country = "Chile", Currency = "CLP", Language = "ESP" },
                new CountryInfo { Country = "Colombia", Currency = "COP", Language = "ESP" },
                new CountryInfo { Country = "Costa Rica", Currency = "CRC", Language = "ESP" },
                new CountryInfo { Country = "Cuba", Currency = "CUP", Language = "ESP" },
                new CountryInfo { Country = "Ecuador", Currency = "USD", Language = "ESP" },
                new CountryInfo { Country = "El Salvador", Currency = "USD", Language = "ESP" },
                new CountryInfo { Country = "Estados Unidos", Currency = "USD", Language = "ENG" },
                new CountryInfo { Country = "Guatemala", Currency = "GTQ", Language = "ESP" },
                new CountryInfo { Country = "Haití", Currency = "HTG", Language = "FR, CRI" },
                new CountryInfo { Country = "Honduras", Currency = "HNL", Language = "ESP" },
                new CountryInfo { Country = "Jamaica", Currency = "JMD", Language = "ENG" },
                new CountryInfo { Country = "México", Currency = "MXN", Language = "ESP" },
                new CountryInfo { Country = "Nicaragua", Currency = "NIO", Language = "ESP" },
                new CountryInfo { Country = "Panamá", Currency = "PAB", Language = "ESP" },
                new CountryInfo { Country = "Paraguay", Currency = "PYG", Language = "ESP, GU" },
                new CountryInfo { Country = "Perú", Currency = "PEN", Language = "ESP" },
                new CountryInfo { Country = "República Dominicana", Currency = "DOP", Language = "ESP" },
                new CountryInfo { Country = "Uruguay", Currency = "UYU", Language = "ESP" },
                new CountryInfo { Country = "Venezuela", Currency = "VES", Language = "ESP" }
            };

        pickerPaises.ItemsSource = paises;
    }

    private void OnCountryPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        var paisSeleccionado = (CountryInfo)picker.SelectedItem;

        if (paisSeleccionado != null)
        {
            // Habilitar los otros pickers
            pickerMonedas.IsEnabled = true;
            pickerIdiomas.IsEnabled = true;

            // Actualizar el Picker de Monedas
            pickerMonedas.ItemsSource = paises.Select(p => p.Currency).Distinct().ToList();
            pickerMonedas.SelectedItem = paisSeleccionado.Currency; // Seleccionar la moneda del país

            // Recopilar todos los idiomas de todos los países
            var todosLosIdiomas = paises.SelectMany(p => p.Language.Split(", ")).Distinct().ToList();

            // Añadir el idioma del país seleccionado al inicio de la lista
            if (!todosLosIdiomas.Contains(paisSeleccionado.Language))
            {
                todosLosIdiomas.Insert(0, paisSeleccionado.Language); // Agregar el idioma del país al inicio
            }

            // Configurar el ItemsSource del Picker de Idiomas
            pickerIdiomas.ItemsSource = todosLosIdiomas;

            // Establecer el idioma del país seleccionado como seleccionado
            pickerIdiomas.SelectedItem = paisSeleccionado.Language;
        }
    }

    private void OnPickerCurrencySelectedIndexChanged(object sender, EventArgs e)
    {
        // Aquí puedes manejar la lógica cuando se cambia el Picker de Monedas
    }

    private void OnPickerLanguageSelectedIndexChanged(object sender, EventArgs e)
    {
        // Aquí puedes manejar la lógica cuando se cambia el Picker de Idiomas
    }

    private void OnMilesPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        _ = picker.SelectedItem.ToString();
    }

    private void OnGallonsPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        _ = picker.SelectedItem.ToString();
    }
}