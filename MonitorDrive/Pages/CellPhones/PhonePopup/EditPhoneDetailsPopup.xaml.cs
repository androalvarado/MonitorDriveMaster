using CommunityToolkit.Maui.Views;

namespace MonitorDrive.Pages.CellPhones.PhonePopup;

public partial class EditPhoneDetailsPopup : Popup
{
	public EditPhoneDetailsPopup()
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