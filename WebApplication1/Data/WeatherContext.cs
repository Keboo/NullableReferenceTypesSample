using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class WeatherContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<WeatherEvent> WeatherEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=weather.db");
    }
}
