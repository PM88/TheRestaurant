using System;
using System.Collections.Generic;
using TheRestaurant.Models;

namespace TheRestaurant.ViewModels
{
    public class RecipeFormViewModel
    {
        //public IEnumerable<Ingredient> Ingredients { get; set; }
        public Recipe Recipe { get; set; }
        public IEnumerable<DishType> DishTypes { get; set; }
    }
}