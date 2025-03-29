using Microsoft.EntityFrameworkCore;

namespace CarRentalApi.Data;
public class CarRentalDbContext : DbContext
{
    public CarRentalDbContext(DbContextOptions<CarRentalDbContext> options) : base(options) { }

    public DbSet<Car> Cars { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Customer> Customers { get; set; }
}
