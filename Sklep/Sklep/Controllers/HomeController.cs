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
            var topLongest = db.Films.OrderByDescending(f => f.FilmLength).Take(3).ToList();
            var vm = new IndexLongestViewModel() { LongestFilms = topLongest };
            return View(vm);
        }

        public ActionResult StaticSite(string name)
        {
            return View(name);
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}