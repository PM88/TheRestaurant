using System.ComponentModel.DataAnnotations;

namespace TheRestaurant.Models
{
    public class IngredientUnit
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}