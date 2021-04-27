using Sklep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.ViewModels
{
    public class CartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public decimal TotalPrice { get; set; }
        public int TotalQuantity { get; set; }
    }
}