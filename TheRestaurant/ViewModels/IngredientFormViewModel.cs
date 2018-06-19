using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TheRestaurant.Models;

namespace TheRestaurant.ViewModels
{
    public class IngredientFormViewModel
    {
        public IEnumerable<IngredientUnit> IngredientUnits { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Ingredient unit")]
        [Required]
        public byte? IngredientUnitId { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required]
        public byte? NumberInStock { get; set; }


        public string Title
        {
            get
            {
                return Id != 0 ? "Edit ingredient" : "New ingredient";
            }
        }

        public IngredientFormViewModel()
        {
            Id = 0;
        }

        public IngredientFormViewModel(Ingredient ingredient)
        {
            Id = ingredient.Id;
            Name = ingredient.Name;
            NumberInStock = ingredient.NumberInStock;
            IngredientUnitId = ingredient.IngredientUnitId;
        }
    }
}