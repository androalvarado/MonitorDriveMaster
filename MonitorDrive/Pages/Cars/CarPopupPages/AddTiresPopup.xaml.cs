using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace MonitorDrive.Pages.Cars.CarPopupPages;

public partial class AddTiresPopup : Popup
{
    public ObservableCollection<int> TiresDurationOptions { get; set; }

    public AddTiresPopup()
	{
		InitializeComponent();
        InitializeTiresDurationPicker();
    }

    private void InitializeTiresDurationPicker()
    {
        TiresDurationOptions = new ObservableCollection<int>();
        for (int i = 0; i <= 72; i += 3)
        {
            TiresDurationOptions.Add(i);
        }

        TiresDurationPicker.ItemsSource = TiresDurationOptions;
        TiresDurationPicker.SelectedIndexChanged += OnTiresDurationPickerSelectedIndexChanged;
    }

    private void OnTiresDurationPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        if (TiresDurationPicker.SelectedIndex != -1)
        {
            int selectedDuration = TiresDurationOptions[TiresDurationPicker.SelectedIndex];
            // Aquí puedes hacer algo con la duración seleccionada, como actualizar un ViewModel o una propiedad
        }
    }

    private void OnCancelButtonCliked(object sender, EventArgs e)
    {
        Close();
    }

    private void OnConfirmButtonCliked(object sender, EventArgs e)
    {
        Close();
    }
}