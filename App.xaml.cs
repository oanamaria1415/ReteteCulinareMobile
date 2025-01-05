using ReteteCulinareMobile.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace ReteteCulinareMobile
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            var recipesPage = serviceProvider.GetRequiredService<RecipesPage>();
            MainPage = new NavigationPage(recipesPage);
        }
    }
}
