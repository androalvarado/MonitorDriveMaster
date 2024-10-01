using System.ComponentModel;
using System.Windows.Input;

namespace MonitorDrive.Pages.Management;

public partial class AddDayWorkInfoPage : ContentPage
{
    // Propiedades del grid para hacer el cambio de estados
    private int currentGridIndex = 0;
    private Grid[] grids;

    public AddDayWorkInfoPage()
	{
		InitializeComponent();

        BindingContext = this;

        grids = new Grid[] { grid1, grid2, grid3};
                
        // Deshabilitar el TabBar
        Shell.SetTabBarIsVisible(this, false);
    }       

    private void OnContinueClicked(object sender, EventArgs e)
    {
        if (currentGridIndex < grids.Length - 1)
        {
            grids[currentGridIndex].IsVisible = false;
            currentGridIndex++;
            grids[currentGridIndex].IsVisible = true;
        }
    }

    private void OnCancelClicked(object sender, EventArgs e)
    {
        if (currentGridIndex > 0)
        {
            grids[currentGridIndex].IsVisible = false;
            currentGridIndex--;
            grids[currentGridIndex].IsVisible = true;
        }
    }

    private async void OnExitFormButtom(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnConfirmClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListInfoPage());

        Navigation.RemovePage(this);

    }

    private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        _ = picker.SelectedItem.ToString();
    }

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        // Obtiene el valor del slider y lo redondea
        _ = (int)e.NewValue;
    }

}