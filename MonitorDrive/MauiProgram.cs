using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace MonitorDrive
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Inter_18pt-Light.ttf", "InterL");
                fonts.AddFont("Inter_18pt-Regular.ttf", "InterR");
                fonts.AddFont("Inter_24pt-Medium.ttf", "InterM");
                fonts.AddFont("Inter_24pt-Bold.ttf", "InterB24");
                fonts.AddFont("Inter_18pt-Bold.ttf", "InterB18");
                fonts.AddFont("Inter_24pt-SemiBold.ttf", "InterSB");
            }).UseMauiCommunityToolkit();
            // Configurar el ícono de la pantalla de carga
            builder.ConfigureFonts(fonts =>
            {
                fonts.AddFont("brain.svg", "SplashIcon");
            });
#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}