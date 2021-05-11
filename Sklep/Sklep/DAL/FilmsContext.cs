using Microsoft.AspNet.Identity.EntityFramework;
using Sklep.Models;
using System.Data.Entity;

namespace Sklep.DAL
{
    public class FilmsContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Film> Films { get; set; }

        public DbSet<Category> Categories { get; set; }

        public FilmsContext() : base("FilmsContext")
        {

        }

        static FilmsContext()
        {
            Database.SetInitializer(new FilmsInitializer());
        }

        public static FilmsContext Create()
        {
            return new FilmsContext();
        }
    }
}