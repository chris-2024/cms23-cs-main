using Kanelbullen.Services;
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

            builder.Services.AddSingleton<MemberService>();

            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<MainPage>();

            builder.Services.AddTransient<DetailViewModel>();
            builder.Services.AddTransient<DetailPage>();

            builder.Services.AddTransient<EditViewModel>();
            builder.Services.AddTransient<EditPage>();

            return builder.Build();
        }
    }
}