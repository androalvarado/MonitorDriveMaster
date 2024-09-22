
using MonitorDrive.Pages;
using MonitorDrive.Pages.Management;
using MonitorDrive.Pages.Masters;
using MonitorDrive.Pages.ProfilePages;
using MonitorDrive.ViewModels;

namespace MonitorDrive.ContentViews;

public partial class NavBarContentView : ContentView
{
    private UserViewModel user;

    public NavBarContentView()
	{
		InitializeComponent();

        BindingContext = this; // Configura el contexto de datos
    }

    private async void OnHomeGridTapped(object sender, EventArgs e)
    {
        // Obtener la página actual
        var currentPage = Navigation.NavigationStack.Last();

        // Crear una instancia de la página de destino
        var DashPage = new DashboardPage();

        // Comprobar si la página actual es la misma que la página de destino
        if (currentPage.GetType() != DashPage.GetType())
        {
            // Navegar a la nueva página
            await Navigation.PushAsync(DashPage);

            // Eliminar la página actual de la pila si es necesario
            Navigation.RemovePage(currentPage);
        }

    }

    private async void OnTravelsGridTapped(object sender, EventArgs e)
    {
        // Obtener la página actual
        var currentPage = Navigation.NavigationStack.Last();

        // Crear una instancia de la página de destino
        var TravelsPage = new ListInfoPage();

        // Comprobar si la página actual es la misma que la página de destino
        if (currentPage.GetType() != TravelsPage.GetType())
        {
            // Navegar a la nueva página
            await Navigation.PushAsync(TravelsPage);

            // Eliminar la página actual de la pila si es necesario
            Navigation.RemovePage(currentPage);
        }

    }

    private async void OnMastersGridTapped(object sender, EventArgs e)
    {
        // Obtener la página actual
        var currentPage = Navigation.NavigationStack.Last();

        // Crear una instancia de la página de destino
        var MastersPage = new MonitorMasterPage();

        // Comprobar si la página actual es la misma que la página de destino
        if (currentPage.GetType() != MastersPage.GetType())
        {
            // Navegar a la nueva página
            await Navigation.PushAsync(MastersPage);

            // Eliminar la página actual de la pila si es necesario
            Navigation.RemovePage(currentPage);
        }

    }

    private async void OnProfileGridTapped(object sender, EventArgs e)
    {
        // Obtener la página actual
        var currentPage = Navigation.NavigationStack.Last();

        // Crear una instancia de la página de destino
        var DestinyPage = new ProfilePage(user);

        // Comprobar si la página actual es la misma que la página de destino
        if (currentPage.GetType() != DestinyPage.GetType())
        {
            // Navegar a la nueva página
            await Navigation.PushAsync(DestinyPage);

            // Eliminar la página actual de la pila si es necesario
            Navigation.RemovePage(currentPage);
        }
    }
}