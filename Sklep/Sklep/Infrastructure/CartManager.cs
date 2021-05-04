using Sklep.DAL;
using Sklep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.Infrastructure
{
    public class CartManager
    {
        FilmsContext db;
        ISessionManager session;

        public CartManager(FilmsContext db, ISessionManager session)
        {
            this.db = db;
            this.session = session;
        }

        public List<CartItem> GetCartItems()
        {
            List<CartItem> items;
            if (session.Get<List<CartItem>>(Consts.CartSessionKey) == null)
                items = new List<CartItem>();
            else
                items = session.Get<List<CartItem>>(Consts.CartSessionKey);
            return items;
        }

        public void AddToCart(int filmId)
        {
            var cart = GetCartItems();
            var thisFilm = cart.Find(item => item.Film.FilmId == filmId);
            if (thisFilm != null)
            {
                thisFilm.Quantity++;
            }
            else
            {
                var film = db.Films.Find(filmId);
                if (film == null)
                    return;
                var newCartItem = new CartItem()
                {
                    Film = film,
                    Quantity = 1,
                    Price = film.Price
                };
                cart.Add(newCartItem);
            }

            session.Set(Consts.CartSessionKey, cart);
        }


        public int RemoveFromCart(int filmId)
        {
            var cart = GetCartItems();
            var thisFilm = cart.Find(item => item.Film.FilmId == filmId);
            if (thisFilm != null)
            {
                if (thisFilm.Quantity > 1)
                {
                    thisFilm.Quantity--;
                    return thisFilm.Quantity;
                }
                else
                {
                    cart.Remove(thisFilm);
                }
            }

            return 0;
        }

        public int GetCartQuantity()
        {
            return GetCartItems().Sum(item => item.Quantity);
        }

        public decimal GetCartValue()
        {
            return GetCartItems().Sum(item => item.Quantity * item.Price);
        }
    }
}