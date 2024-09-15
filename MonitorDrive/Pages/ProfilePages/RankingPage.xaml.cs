using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace MonitorDrive.Pages.ProfilePages;

public partial class RankingPage : ContentPage
{
    public ObservableCollection<RankingItem> Rankings { get; set; }
    public RankingPage()
	{   
                InitializeComponent();
        // Deshabilitar el TabBar
        Shell.SetTabBarIsVisible(this, false);

        Rankings = new ObservableCollection<RankingItem>
            {
                new RankingItem { Rank = 1, User = "profile.png", Level = "Gold", Points = 1500 },
                new RankingItem { Rank = 2, User = "User2", Level = "Silver", Points = 1200 },
                new RankingItem { Rank = 3, User = "User3", Level = "Bronze", Points = 900 },
                new RankingItem { Rank = 4, User = "User4", Level = "Bronze", Points = 900 },
                new RankingItem { Rank = 5, User = "User5", Level = "Bronze", Points = 900 },
                new RankingItem { Rank = 6, User = "User6", Level = "Bronze", Points = 900 },
                new RankingItem { Rank = 7, User = "User7", Level = "Bronze", Points = 900 },
                new RankingItem { Rank = 8, User = "User8", Level = "Bronze", Points = 900 },
                new RankingItem { Rank = 9, User = "User9", Level = "Bronze", Points = 900 },
                new RankingItem { Rank = 10, User = "User10", Level = "Bronze", Points = 900 }
            };
        BindingContext = this;

        // Establecer el botón "Today" como seleccionado por defecto
        SelectButton(TodayButton);
    }

    private void OnFilterButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        SelectButton(button);
        // Aquí puedes agregar la lógica para filtrar el ranking según el botón seleccionado
    }

    private void SelectButton(Button selectedButton)
    {
        string primaryColor = "#B69CFA";

        // Restablecer todos los botones a su estado original
        TodayButton.BackgroundColor = Colors.Transparent;
        WeekButton.BackgroundColor = Colors.Transparent;
        AllTimeButton.BackgroundColor = Colors.Transparent;

        // Cambiar el color del botón seleccionado
        selectedButton.BackgroundColor = Color.FromArgb(primaryColor);
        selectedButton.TextColor = Colors.White;
    }

    public class RankingItem
    {
        public int Rank { get; set; }
        public string ID { get; set; }
        public string User { get; set; }
        public string Level { get; set; }
        public int Points { get; set; }
    }
}

     