using System.ComponentModel;
using System.Runtime.CompilerServices;
using MonitorDrive.Pages.Cars;
using MonitorDrive.ViewModels;
namespace MonitorDrive.Pages.ProfilePages;

public partial class EditProfileDetailsPage : ContentPage, INotifyPropertyChanged
{
    private UserViewModel ViewModel => BindingContext as UserViewModel;

    public EditProfileDetailsPage(UserViewModel user)
	{
		InitializeComponent();

        BindingContext = new UserViewModel();

        // Deshabilitar el TabBar
        Shell.SetTabBarIsVisible(this, false);
    }

    public EditProfileDetailsPage()
    {
    }

    private void OnVehicleSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        foreach (var item in e.CurrentSelection)
        {
            ViewModel.AddVehicle(item.ToString());
        }
        foreach (var item in e.PreviousSelection)
        {
            if (!e.CurrentSelection.Contains(item))
            {
                ViewModel.RemoveVehicle(item.ToString());
            }
        }
    }

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void OnCancelButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

}