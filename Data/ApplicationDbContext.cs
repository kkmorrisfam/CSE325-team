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
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Booking> Booking { get; set; }
        // This must be *inside* the class body

        public DbSet<Payment> Payment { get; set; }

        public DbSet<Contact> Contact { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // configure one-to-many: ApplicationUser → Contact
            modelBuilder.Entity<Contact>()
                .HasOne(c => c.ApplicationUser)
                .WithMany(u => u.Contacts)
                .HasForeignKey(c => c.ApplicationUserId);
        }


    }
}
