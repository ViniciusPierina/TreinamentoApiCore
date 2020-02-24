using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configurations
{
    public sealed class ConfigurationContext : DbContext
    {
        public ConfigurationContext(DbContextOptions<ConfigurationContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
