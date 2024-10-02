using CommunityToolkit.Maui.Views;

namespace MonitorDrive.Pages.Cars.CarPopupPages;

public partial class AddCarPaymentPopup : Popup
{
	public AddCarPaymentPopup()
	{
		InitializeComponent();
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