using CommunityToolkit.Maui;
using MAUI.MaintenanceApp.ViewModels;
using Microsoft.Extensions.Logging;

namespace MAUI.MaintenanceApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            //Dependency injection...
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<LoginViewModel>();

            return builder.Build();
        }
    }
}