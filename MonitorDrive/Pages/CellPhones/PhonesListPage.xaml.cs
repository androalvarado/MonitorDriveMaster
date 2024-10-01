using CommunityToolkit.Maui.Views;
using MonitorDrive.Pages.CellPhones.PhonePopup;

namespace MonitorDrive.Pages.CellPhones;

public partial class PhonesListPage : ContentPage
{
	public PhonesListPage()
	{
		InitializeComponent();
	}

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnAddClicked(object sender, EventArgs e)
    {
        await this.ShowPopupAsync(new EditPhoneDetailsPopup());
    }

    private async void OnPhoneTapped(object sender, TappedEventArgs e)
    {
        await this.ShowPopupAsync(new EditPhoneDetailsPopup());
    }
}