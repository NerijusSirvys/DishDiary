using CommunityToolkit.Maui;
using DishDiary.Mobile.Services.Dish;
using DishDiary.Mobile.ViewModels;
using Microsoft.Extensions.Logging;

namespace DishDiary.Mobile
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
#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<AppShell>();
            builder.Services.AddSingleton<DishListPage>();
            builder.Services.AddSingleton<DishListViewModel>();
            builder.Services.AddTransient<DishService>();

            return builder.Build();
        }
    }
}
