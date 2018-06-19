using System.ComponentModel.DataAnnotations;

namespace TheRestaurant.Models
{
    public class DishType
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}