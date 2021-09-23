using Microsoft.EntityFrameworkCore;
using HomePC.App.Dominio;

namespace HomePC.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            if(!OptionsBuilder.IsConfigured)
            {
                OptionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =HomePCtData");
            }
        }              
    }
}