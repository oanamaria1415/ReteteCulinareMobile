using ReteteCulinareMobile.ViewModels;

namespace ReteteCulinareMobile.Pages;

public partial class RecipesPage : ContentPage
{
    public RecipesPage(RecipesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
