using ReteteCulinareMobile.Pages;
using ReteteCulinareMobile.ViewModels;

public partial class App : Application
{
    public App(IServiceProvider serviceProvider)
    {
        InitializeComponent();

        var recipesPage = new RecipesPage(serviceProvider.GetRequiredService<RecipesViewModel>());
        MainPage = new NavigationPage(recipesPage);
    }
}
