using Sklep.DAL;
using Sklep.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sklep.Controllers
{
    public class FilmsController : Controller
    {
        FilmsContext db = new FilmsContext();

        // GET: Films
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c => c.Name.ToLower() == categoryName.ToLower()).Single();
            IEnumerable<Models.Film> nowosci = db.Films.OrderByDescending(f => f.AddDate).Take(3);
            ListViewModel vm = new ListViewModel()
            {
                Category = category,
                FilmsFromCategory = category.Films.ToList(),
                Top3NewestFilms = nowosci
            };
            return View(vm);
        }

        public ActionResult Details(int id)
        {
            Models.Film film = db.Films.Find(id);

            return View(film);
        }

        [ChildActionOnly]
        public ActionResult CategoriesMenu()
        {
            var categoryList = db.Categories.ToList();
            return PartialView("_CategoriesMenu", categoryList);
        }

        [ChildActionOnly]
        public ActionResult FilmsFromCategory(string categoryName)
        {
            var categoryWithFilms = db.Categories.Include("Films").Where(c => c.Name.ToLower() == categoryName.ToLower()).Single();
            return PartialView("_FilmsFromCategory", categoryWithFilms.Films.ToList());
        }
    }
}