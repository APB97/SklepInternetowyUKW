using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Sklep.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Sklep.DAL.FilmsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SklepUKW.DAL.FilmsContext";
        }

        protected override void Seed(Sklep.DAL.FilmsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}