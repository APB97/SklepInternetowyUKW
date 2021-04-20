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
            return View();
        }

        public ActionResult StaticSite(string name)
        {
            return View(name);
        }
    }
}