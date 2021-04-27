using Sklep.DAL;
using Sklep.Infrastructure;
using Sklep.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sklep.Controllers
{
    public class CartController : Controller
    {
        FilmsContext db;
        ISessionManager session;
        CartManager cartManager;

        public CartController()
        {
            db = new FilmsContext();
            session = new SessionManager();
            cartManager = new CartManager(db, session);
        }


        // GET: Cart
        public ActionResult Index()
        {
            var cvm = new CartViewModel()
            {
                CartItems = cartManager.GetCartItems(),
                TotalQuantity = cartManager.GetCartQuantity(),
                TotalPrice = cartManager.GetCartValue()
            };
            return View(cvm);
        }

        public ActionResult AddToCart(int id)
        {
            cartManager.AddToCart(id);
            return RedirectToAction(nameof(Index));
        }
    }
}