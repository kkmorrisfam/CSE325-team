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
            if (await context.Bookings.AnyAsync())
                return;

            // Add initial booking data here
            // Example:
            // context.Bookings.Add(new Booking { ... });
            // await context.SaveChangesAsync();



            var user1 = await context.Users.FirstOrDefaultAsync(u => u.Email == "user@gmail.com");
            var vehicle1 = await context.Vehicles.FirstOrDefaultAsync(v => v.VehicleId == 1);

            if (user1 != null && vehicle1 != null)
            {
                context.Bookings.Add(
                    new Booking
                    {
                        PickupDate = DateTime.UtcNow,
                        DropOffDate = DateTime.UtcNow.AddDays(3),
                        TotalPrice = 269.97m,
                        VehicleId = vehicle1.VehicleId,
                        UserId = user1.UserId.ToString(),
                    });

                await context.SaveChangesAsync();
            }

        }


    }
}