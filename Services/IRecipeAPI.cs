using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;
using ReteteCulinareMobile.Models;

namespace ReteteCulinareMobile.Services
{
    public interface IRecipeApi
    {
        [Get("/api/Recipes")]
        Task<List<Recipe>> GetRecipesAsync();

        [Get("/api/Recipes/{id}")]
        Task<Recipe> GetRecipeByIdAsync(int id);

        [Post("/api/Recipes")]
        Task AddRecipeAsync([Body] Recipe recipe);

        [Put("/api/Recipes/{id}")]
        Task UpdateRecipeAsync(int id, [Body] Recipe recipe);

        [Delete("/api/Recipes/{id}")]
        Task DeleteRecipeAsync(int id);
    }
}
