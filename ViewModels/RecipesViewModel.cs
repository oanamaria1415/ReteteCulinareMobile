using System.Collections.ObjectModel;
using ReteteCulinareMobile.Models;
using ReteteCulinareMobile.Services;
using System.ComponentModel;

namespace ReteteCulinareMobile.ViewModels
{
    public class RecipesViewModel 
    {
        private readonly IRecipeApi _recipeApi;

        public ObservableCollection<Recipe> Recipes { get; } = new();

        public RecipesViewModel(IRecipeApi recipeApi)
        {
            _recipeApi = recipeApi;
            LoadRecipes();
        }

        private async void LoadRecipes()
        {
            try
            {
                var recipes = await _recipeApi.GetRecipesAsync();
                foreach (var recipe in recipes)
                {
                    Recipes.Add(recipe);
                }
            }
            catch (Exception ex)
            {
                // Tratează erorile (ex: logare sau afișare mesaj utilizator)
            }
        }
    }
}
