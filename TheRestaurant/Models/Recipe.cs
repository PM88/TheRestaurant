using System;
using System.ComponentModel.DataAnnotations;

namespace TheRestaurant.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DishType DishType { get; set; }

        [Display(Name = "Dish Type")]
        public byte DishTypeId { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        //[Column(TypeName = "datetime2")]
        public DateTime DateAdded { get; set; }
    }
}