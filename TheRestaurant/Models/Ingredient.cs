using System.ComponentModel.DataAnnotations;

namespace TheRestaurant.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        public IngredientUnit IngredientUnit { get; set; }

        [Display(Name = "Ingredient unit")]
        [Required]
        public byte IngredientUnitId { get; set; }
    }
}