using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace MonitorDrive.Pages.Cars.CarPopupPages;

public partial class AddCarPaymentPopup : Popup
{
    public ObservableCollection<int> TimeOptions { get; set; }
    public AddCarPaymentPopup()
	{
		InitializeComponent();
        InitializeTimePicker();
    }

    private void InitializeTimePicker()
    {
        TimeOptions = new ObservableCollection<int>();
        for (int i = 0; i <= 72; i += 3)
        {
            TimeOptions.Add(i);
        }

        EstraExpenseMountToPayPicker.ItemsSource = TimeOptions;
        EstraExpenseMountToPayPicker.SelectedIndexChanged += OnTimePickerSelectedIndexChanged;
    }

    private void OnTimePickerSelectedIndexChanged(object sender, EventArgs e)
    {
        if (EstraExpenseMountToPayPicker.SelectedIndex != -1)
        {
            _ = TimeOptions[EstraExpenseMountToPayPicker.SelectedIndex];
            // Aquí puedes hacer algo con el tiempo seleccionado, como actualizar un ViewModel o una propiedad
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

    private void OnPaymnetCategoryPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        _ = picker.SelectedItem.ToString();
    }
}