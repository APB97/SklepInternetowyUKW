using Sklep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.ViewModels
{
    public class IndexLongestViewModel
    {
        public IEnumerable<Film> LongestFilms { get; set; }
    }
}