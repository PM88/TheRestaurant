using System.ComponentModel.DataAnnotations;

namespace TheRestaurant.Models
{
    public class RecipeIngredient
    {
        public int Id { get; set; }

        [Required]
        public Recipe Recipe { get; set; }

        //[Display(Name = "Recipe")]
        //public byte RecipeId { get; set; }

        [Required]
        public Ingredient Ingredient { get; set; }

        //[Display(Name = "Ingredient")]
        //public byte IngredientId { get; set; }

        [Display(Name = "Number of ingredients")]
        [Range(1, 20)]
        public byte NumberOfIngredients { get; set; }
    }
}