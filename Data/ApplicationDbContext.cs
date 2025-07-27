using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CSE325_team.Models;    


namespace CSE325_team.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        // Constructor needs to call the base IdentityDbContext ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // This must be *inside* the class body
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
