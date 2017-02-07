using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WikiPages.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WikiPages.Controllers
{
    public class RestaurantsController : Controller
    {
        private WikiPagesContext db = new WikiPagesContext();

        public IActionResult Index()
        {
            return View(db.Restaurants.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisRestaurant = db.Restaurants.FirstOrDefault(restaurant => restaurant.Id == id);
            return View(thisRestaurant);
        }

        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            db.Restaurants.Add(restaurant);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
