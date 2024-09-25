using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Threading.Tasks;

namespace MonitorDrive.ViewModels
{
    public partial class UserViewModel : ObservableObject
    {
        [ObservableProperty]
        private int id;

        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private string lastName;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string cellphone;

        [ObservableProperty]
        private string selectedCountry;

        [ObservableProperty]
        private string selectedCurrency;

        [ObservableProperty]
        public string fullName;

        [ObservableProperty]
        private ObservableCollection<string> selectedVehicles;

        public ObservableCollection<string> Countries { get; } = new ObservableCollection<string> { "Estados Unidos", "México", "Argentina", "Colombia", "Chile" };
        public ObservableCollection<string> Currencies { get; } = new ObservableCollection<string> { "EUR", "USD", "MXN", "ARS", "COP", "CLP" };
        public ObservableCollection<string> AvailableVehicles { get; } = new ObservableCollection<string>
        {
            "Audi A4",
            "Toyota Corolla",
            "Ford Mustang"
        };

        public UserViewModel()
        {
            SelectedVehicles = new ObservableCollection<string>();
        }

        [RelayCommand]
        public void AddVehicle(string vehicle)
        {
            if (!SelectedVehicles.Contains(vehicle))
            {
                SelectedVehicles.Add(vehicle);
            }
        }

        [RelayCommand]
        public void RemoveVehicle(string vehicle)
        {
            SelectedVehicles.Remove(vehicle);
        }
    }

    public partial class UserProfileViewModel : ObservableObject
    {
        [ObservableProperty]
        private UserViewModel user; // Cambiado a una sola instancia de UserViewModel

        public UserProfileViewModel()
        {
            User = new UserViewModel(); // Inicializa el usuario
            LoadUser(); // Carga los datos del usuario
        }

        private void LoadUser()
        {
            // Simulando la carga de un usuario desde una base de datos
            User.Id = 1;
            User.Name = "Andrew";
            User.LastName = "Smith";
            User.FullName = $"{User.Name} {User.LastName}";
            User.Cellphone = "Iphone 13";
            User.Email = "andrewsmith@gmail.com";
            User.SelectedCountry = "Estados Unidos";
            User.SelectedCurrency = "USD";
            User.SelectedVehicles = User.AvailableVehicles;
        }
            [RelayCommand]
        public async Task SaveChanges()
        {
            // Simulando guardar cambios
            await Task.Delay(1000); // Simulando un retraso en la red
        }
    }

}
