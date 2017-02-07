using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WikiPages.Models;


namespace WikiPages.Controllers
{
    public class CategoriesController : Controller
    {
        private WikiPagesContext db = new WikiPagesContext();
        public IActionResult Index()
        {
            return View(db.Categories.ToList());
        }
    }
}
