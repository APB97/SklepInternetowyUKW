using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Sklep.Infrastructure
{
    public class AppConfig
    {
        private static string imagesPath = ConfigurationManager.AppSettings["Images"];

        public static string ImagesPath => imagesPath;
    }
}