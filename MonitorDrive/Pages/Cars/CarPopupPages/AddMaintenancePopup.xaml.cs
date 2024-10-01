using CommunityToolkit.Maui.Views;

namespace MonitorDrive.Pages.Cars.CarPopupPages;
public partial class AddMaintenancePopup: Popup
{
	public AddMaintenancePopup()
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
}