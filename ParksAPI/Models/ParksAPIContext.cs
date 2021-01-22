using Microsoft.EntityFrameworkCore;

namespace ParksAPI.Models
{
    public class ParksAPIContext : DbContext
    {
        public ParksAPIContext(DbContextOptions<ParksAPIContext> options) : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                .HasData(
                    new Park { ParkId = 1, ParkName = "Yosemite National Park", ParkLocation = "Sierra-Nevada Mountains, California, USA.", Description = "A 1200-mile area of land best known for its amazing waterfalls and rock formations." },
                    new Park { ParkId = 2, ParkName = "Fort Wardon State Park", ParkLocation = "Port Townsand, Washington, USA.", Description = "Decommissioned fort on the Puget Sound, home to a vast array of bunkers and museums." },
                    new Park { ParkId = 3, ParkName = "Crater Lake National Park", ParkLocation = "Southern Oregon, USA", Description = "A massive lake that lies in the remnants of the ancient volcano Mazama. The ninth deepest lake in the world." });
        }
    }
}
