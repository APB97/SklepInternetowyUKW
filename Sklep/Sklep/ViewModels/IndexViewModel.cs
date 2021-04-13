using Sklep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Category> Categories { get; set; }


    }
}