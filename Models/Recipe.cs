using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteteCulinareMobile.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }
        public string ChefName { get; set; }
        public string Instructions { get; set; }
        public string Category { get; set; }
        public string ImagePath { get; set; }
    }
}
