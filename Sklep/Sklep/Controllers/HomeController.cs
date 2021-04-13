using Sklep.DAL;
using Sklep.Models;
using Sklep.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sklep.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db = new FilmsContext();

        // GET: Home
        public ActionResult Index()
        {
            //db.Categories.Add(new Category { CategoryId = 7, Name = "Anime", Desc = "Nani?" });

            var categories = db.Categories.ToList();

            var ivm = new IndexViewModel() { Categories = categories };

            return View(ivm);
        }

        public ActionResult StaticSite(string name)
        {
            return View(name);
        }
    }
}