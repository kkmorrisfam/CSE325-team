using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CSE325_team.Models;

namespace CSE325_team.Data
{
    public class SeedBooking
    {
        public static async Task InitializeAsync(ApplicationDbContext context)
        {
            if (await context.Booking.AnyAsync())
                return;

            // Add initial booking data here
            // Example:
            // context.Booking.Add(new Booking { ... });
            // await context.SaveChangesAsync();



            var user1 = await context.Users.FirstOrDefaultAsync(u => u.UserName == "user@gmail.com");
            var vehicle1 = await context.Vehicle.FirstOrDefaultAsync(v => v.VehicleId == 1);

            if (user1 != null && vehicle1 != null)
            {
                context.Booking.AddRange(
                    new Booking
                    {
                        StartDate = DateTime.UtcNow,
                        EndDate = DateTime.UtcNow.AddDays(3),
                        TotalPrice = 269.97m,
                        Vehicle = vehicle1,
                        UserId = user1.Id,
                        User = user1
                    });

                await context.SaveChangesAsync();
            }

        }


    }
}