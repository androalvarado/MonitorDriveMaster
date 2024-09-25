using CommunityToolkit.Mvvm.ComponentModel;
using MonitorDrive.Models;
using System;
using System.Collections.ObjectModel;

namespace MonitorDrive.ViewModels
{
    public partial class TravelViewModel : ObservableObject
    {
        // Propiedades observables para el viaje
        [ObservableProperty]
        private DateTime date;

        [ObservableProperty]
        private double distance;

        [ObservableProperty]
        private TimeSpan startTime;

        [ObservableProperty]
        private TimeSpan endTime;

        [ObservableProperty]
        private decimal totalAmount;

        [ObservableProperty]
        private decimal tips;

        [ObservableProperty]
        private int numberOfTravels;

        public ObservableCollection<Travel> Travels { get; } = new ObservableCollection<Travel>(); // Inicialización correcta

        public TravelViewModel()
        {
            LoadTravels();
        }

        private void LoadTravels()
        {
            // Simulando la carga de información de viajes
            Travels.Add(new Travel
            {
                Date = DateTime.Now,
                Distance = 15.5,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(9, 0, 0),
                TotalAmount = 30.00m,
                Tips = 5.00m,
                NumberOfTravels = 3
            });
        }

        // Constructor adicional para instanciar un Viaje específico (si es necesario)
        public TravelViewModel(DateTime date, double distance, TimeSpan startTime, TimeSpan endTime, decimal totalAmount, decimal tips, int numberOfTravels)
        {
            Date = date;
            Distance = distance;
            StartTime = startTime;
            EndTime = endTime;
            TotalAmount = totalAmount;
            Tips = tips;
            NumberOfTravels = numberOfTravels;
        }
    }
}
