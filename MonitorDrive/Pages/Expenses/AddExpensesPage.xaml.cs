namespace MonitorDrive.Pages.Expenses;

public partial class AddExpensesPage : ContentPage
{
	public AddExpensesPage()
	{
		InitializeComponent();
	}

    private async void OnConfirmClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private void OnCategorySelected(object sender, EventArgs e)
    {
        var selectedCategory = (sender as Picker).SelectedItem as string;

        // Ocultar todos los Grids
        GasolineGrid.IsVisible = false;
        GroceryGrid.IsVisible = false;
        ExtraExpenseGrid.IsVisible = false;
        ChargeGrid.IsVisible = false;

        // Mostrar el Grid correspondiente a la categoría seleccionada
        switch (selectedCategory)
        {
            case "Gasoline":
                GasolineGrid.IsVisible = true;
                break;
            case "Charge":
                ChargeGrid.IsVisible = true;
                break;
            case "Grocery":
                GroceryGrid.IsVisible = true;
                break;
            case "Extra":
                ExtraExpenseGrid.IsVisible = true;
                break;
            default:
                break;
        }
    }
}