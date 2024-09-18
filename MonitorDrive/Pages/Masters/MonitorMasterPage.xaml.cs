using MonitorDrive.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MonitorDrive.Pages.Masters;

public partial class MonitorMasterPage : ContentPage
{
    public ObservableCollection<Video> Videos { get; set; }
    public MonitorMasterPage()
	{
        InitializeComponent();
        Videos = new ObservableCollection<Video>
        {
            new Video { Titulo = "Introducing Professional Master Monitor #1", Duracion = "3:45", Url = "https://www.youtube.com/embed/S6qDLtZPLb4" },
            new Video { Titulo = "Introducing Professional Master Monitor #2", Duracion = "4:20", Url = "https://www.youtube.com/embed/_XT5ANgERLc" },
            new Video { Titulo = "Introducing Professional Master Monitor #3", Duracion = "2:20", Url = "https://www.youtube.com/embed/_XT5ANgERLc" },
            new Video { Titulo = "Introducing Professional Master Monitor #4", Duracion = "4:70", Url = "https://www.youtube.com/embed/ACmbdiyk2Ak" },
            new Video { Titulo = "Introducing Professional Master Monitor #5", Duracion = "6:20", Url = "https://www.youtube.com/embed/S6qDLtZPLb4" },
            new Video { Titulo = "Introducing Professional Master Monitor #6", Duracion = "6:20", Url = "https://www.youtube.com/embed/_XT5ANgERLc" },
            new Video { Titulo = "Introducing Professional Master Monitor #7", Duracion = "6:20", Url = "https://www.youtube.com/embed/_XT5ANgERLc" },
            new Video { Titulo = "Introducing Professional Master Monitor #8", Duracion = "6:20", Url = "https://www.youtube.com/embed/_XT5ANgERLc" },
            new Video { Titulo = "Introducing Professional Master Monitor #9", Duracion = "6:20", Url = "https://www.youtube.com/embed/_XT5ANgERLc" },
            new Video { Titulo = "Introducing Professional Master Monitor #10", Duracion = "6:20", Url = "https://www.youtube.com/embed/_XT5ANgERLc" }
            // Agrega más videos aquí
        };

        VideosCollectionView.ItemsSource = Videos;

        // Seleccionar el primer video por defecto
        if (Videos.Count > 0)
        {
            VideosCollectionView.SelectedItem = Videos[0];
            VideoWebView.Source = Videos[0].Url; // Cargar el video seleccionado
        }

    }

    private void OnVideoSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count > 0)
        {
            var selectedVideo = e.CurrentSelection[0] as Video;
            VideoWebView.Source = selectedVideo.Url;
        }
    }

    private void OnWebViewNavigating(object sender, WebNavigatingEventArgs e)
    {
        LoadingIndicator.IsVisible = true;
        LoadingIndicator.IsRunning = true;
    }

    private void OnWebViewNavigated(object sender, WebNavigatedEventArgs e)
    {
        LoadingIndicator.IsVisible = false;
        LoadingIndicator.IsRunning = false;
    }

}