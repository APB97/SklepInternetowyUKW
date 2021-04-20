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
            IndexViewModel vm = new IndexViewModel()
            {
                Category = category,
                FilmsFromCategory = category.Films.ToList(),
                Top3NewestFilms = nowosci
            };
            return View(vm);
        }

        [ChildActionOnly]
        public ActionResult CategoriesMenu()
        {
            var categoryList = db.Categories.ToList();
            return PartialView("_CategoriesMenu", categoryList);
        }
    }
}