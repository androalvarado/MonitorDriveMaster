using Microsoft.Extensions.Logging;

namespace MonitorDrive
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");                    
                    fonts.AddFont("Inter_18pt-Light.ttf", "InterL");
                    fonts.AddFont("Inter_18pt-Regular.ttf", "InterR");
                    fonts.AddFont("Inter_24pt-Medium.ttf", "InterM");
                    fonts.AddFont("Inter_24pt-Bold.ttf", "InterB24");
                    fonts.AddFont("Inter_18pt-Bold.ttf", "InterB18");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();

        }

    }
}
