﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MonitorDrive.Pages.Cars;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MonitorDrive.ViewModels
{
    public partial class CarViewModel : ObservableObject
    {
        [ObservableProperty]
        private string brand;

        [ObservableProperty]
        private string model;

        [ObservableProperty]
        private decimal economicValue;

        [ObservableProperty]
        private int miles;

        [ObservableProperty]
        private double mpg;

        // Propiedad combinada
        public string FullDescription => $"{Brand} {Model}";

        // Colección de carros
        public ObservableCollection<CarViewModel> Cars { get; } = new ObservableCollection<CarViewModel>();

        // Constructor
        public CarViewModel()
        {
            LoadCars();
        }

        private void LoadCars()
        {
            // Simulando la carga de información de carros
            Cars.Add(new CarViewModel("Audi", "A4 2020", 35000m, 15000, 28));
            Cars.Add(new CarViewModel("Toyota", "Corolla 2021", 20000m, 5000, 30));
        }

        // Constructor adicional para instanciar un carro específico
        public CarViewModel(string brand, string model, decimal economicValue, int miles, double mpg)
        {
            Brand = brand;
            Model = model;
            EconomicValue = economicValue;
            Miles = miles;
            Mpg = mpg;
        }
    }

    public partial class CarDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private string brand;

        [ObservableProperty]
        private string fullDescription;

        [ObservableProperty]
        private decimal economicValue;

        [ObservableProperty]
        private int miles;

        [ObservableProperty]
        private double mpg;

        [ObservableProperty]
        private int usagePercentage;

        public CarDetailsViewModel()
        {
            Title = "Default Title";
            Brand = "Default Brand";
            FullDescription = "Default Full Description";
            EconomicValue = 0;
            Miles = 0;
            Mpg = 0;
            UsagePercentage = 0;
        }

        public CarDetailsViewModel(CarViewModel car) : this()
        {
            Title = $"Your {car.Brand} Details";
            Brand = car.Brand;
            FullDescription = car.FullDescription;
            EconomicValue = car.EconomicValue;
            Miles = car.Miles;
            Mpg = car.Mpg;
            UsagePercentage = 65;
        }
    }
}
