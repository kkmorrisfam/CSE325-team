

// using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using CSE325_team.Models;

namespace CSE325_team.Data;

public static class SeedPayment
{
    public static async Task InitializeAsync(ApplicationDbContext context)
    {

        if (await context.Payment.AnyAsync())
            return;

            var user1 = await context.Users.FirstOrDefaultAsync(u => u.UserName == "user@gmail.com");
    var booking1 = await context.Booking.FirstOrDefaultAsync(); // Gets first booking — adjust logic if needed

if (user1 == null || booking1 == null)
    {
        Console.WriteLine("Unable to seed Payment — missing user or booking.");
        return;
    }

        context.Payment.AddRange(
            new Payment
            {
                User = user1,
                BookingId = booking1.BookingId,
                Amount = 100.00m,
                PaymentAt = DateTime.UtcNow,
                PaymentMethod = "Credit Card",
                State = "CA",
                Zip = "90001",
                Status = "Completed"
            });

        await context.SaveChangesAsync();
    }
}
