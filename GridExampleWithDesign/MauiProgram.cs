using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PanCardView;

namespace GridExampleWithDesign
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseCardsView()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Nexa-Heavy.ttf", "NexaHeavy");
                    fonts.AddFont("Nexa-ExtraLight.ttf", "NexaExtraLight");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
