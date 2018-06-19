using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TheRestaurant.Models;
using TheRestaurant.ViewModels;

namespace TheRestaurant.Controllers
{
    public class IngredientsController : Controller
    {
        private ApplicationDbContext _context;

        public IngredientsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Ingredients
        public ActionResult Index()
        {
            var ingredients = _context.Ingredients.Include(c => c.IngredientUnit).ToList();
            return View(ingredients);
        }
    }
}