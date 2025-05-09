using CitiesManager.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.WebAPI.DatabaseContext;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public ApplicationDbContext()
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<City>().HasData(
            new City
            {
                CityId = Guid.Parse("242335e4-cb96-4849-a203-3658e7421c73"),
                CityName = "Kivertsi"
            },
            new City
            {
                CityId = Guid.Parse("5d680317-6591-4a9b-ba21-ab91034c94da"),
                CityName = "London"
            }
        );
    }
}