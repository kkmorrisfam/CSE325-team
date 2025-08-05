using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CSE325_team.Models;

namespace CSE325_team.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
            // This must be *inside* the class body
        
        public DbSet<Payment> Payment { get; set; }

    }
}
