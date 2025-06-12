using Microsoft.EntityFrameworkCore;
using Project6_ApiWeather.Entities;

namespace Project6_ApiWeather.Context
{
	public class WeatherContext:DbContext
	{

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=EMRE\\SQLEXPRESS01;initial catalog=MyProject6;integrated security=True;trust server certificate=True;");
		}

        public DbSet<City> Cities { get; set; }
    }
}
