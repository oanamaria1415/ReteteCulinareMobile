using Microsoft.Extensions.Logging;
using ReteteCulinareMobile.Services;
using Refit;

namespace ReteteCulinareMobile;

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

        // Configurarea serviciului API
        builder.Services.AddHttpClient<IRecipeApi>(client =>
        {
            client.BaseAddress = new Uri("http://10.0.2.2:5000");

        });

        // Înregistrarea ViewModel-ului
        builder.Services.AddTransient<RecipesViewModel>();

        return builder.Build();
    }


}

