using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TheRestaurant.Models;
using TheRestaurant.ViewModels;
using System.Web.Http;

namespace TheRestaurant.Controllers
{
    public class RecipesController : Controller
    {
        private ApplicationDbContext _context;

        public RecipesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Recipes
        public ActionResult Index()
        {
            var recipes = _context.Recipes.Include(c => c.DishType).ToList();
            return View(recipes);
        }

        public ActionResult Details(int id)
        {
            var recipe = _context.Recipes.Include(c => c.DishType).SingleOrDefault(c => c.Id == id);
            if (recipe == null)
                return HttpNotFound();

            //var recipeView = new RecipeFormViewModel();
            //recipeView.Recipe = recipe;
            //recipeView.Ingredients = _context.RecipeIngredients.;

            return View(recipe);
        }

        public ActionResult New()
        {
            var dishTypes = _context.DishTypes.ToList();
            var viewModel = new RecipeFormViewModel
            {
                Recipe = new Recipe(),
                DishTypes = dishTypes
            };

            return View("RecipesForm", viewModel);
        }

        //[HttpPost]
        public ActionResult Save(Recipe recipe)
        {
            recipe.DateAdded = DateTime.Now;

            _context.Recipes.Add(recipe);

            _context.SaveChanges();

            return RedirectToAction("Index", "Recipes");
        }
    }
}