using MvcSiteMapProvider;
using Sklep.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.Infrastructure
{
    public class CategoryDynamicNodeProvider : DynamicNodeProviderBase
    {
        FilmsContext db = new FilmsContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            var dynamicNodes = new List<DynamicNode>();
            foreach (var category in db.Categories)
            {
                var dNode = new DynamicNode()
                {
                    Title = category.Name,
                    Key = $"Category_{category.CategoryId}"
                };
                dNode.RouteValues.Add("categoryName", category.Name);
                dynamicNodes.Add(dNode);
            }

            return dynamicNodes;
        }
    }
}