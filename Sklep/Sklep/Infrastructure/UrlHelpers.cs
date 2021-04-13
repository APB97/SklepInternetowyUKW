using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sklep.Infrastructure
{
    public static class UrlHelpers
    {
        public static string GetFullImagePath(this UrlHelper helper, string imageName)
        {
            string folder = AppConfig.ImagesPath;
            string fullPath = Path.Combine(folder, imageName);
            return helper.Content(fullPath);
        }
    }
}