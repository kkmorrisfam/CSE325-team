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

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }


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