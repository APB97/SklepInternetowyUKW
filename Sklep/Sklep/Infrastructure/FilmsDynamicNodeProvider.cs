using MvcSiteMapProvider;
using Sklep.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.Infrastructure
{
    public class FilmsDynamicNodeProvider : DynamicNodeProviderBase
    {
        FilmsContext db = new FilmsContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            var filmsDynamicNodes = new List<DynamicNode>();
            foreach (var film in db.Films)
            {
                var dynamicNode = new DynamicNode()
                {
                    Title = film.Title,
                    Key = $"Film_{film.FilmId}",
                    ParentKey = $"Category_{film.CategoryId}"
                };
                dynamicNode.RouteValues.Add("id", film.FilmId);
                filmsDynamicNodes.Add(dynamicNode);
            }

            return filmsDynamicNodes;
        }
    }
}