using CommunityToolkit.Maui.Views;

namespace MonitorDrive.Pages.Cars.CarPopupPages;

public partial class AddTiresPopup : Popup
{
	public AddTiresPopup()
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