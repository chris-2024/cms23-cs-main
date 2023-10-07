using Kanelbullen.ViewModels;
using Kanelbullen.Views;

namespace Kanelbullen
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
                });

            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPage>();

            builder.Services.AddSingleton<DetailViewModel>();
            builder.Services.AddSingleton<DetailPage>();

            builder.Services.AddSingleton<EditViewModel>();
            builder.Services.AddSingleton<EditPage>();

            return builder.Build();
        }
    }
}