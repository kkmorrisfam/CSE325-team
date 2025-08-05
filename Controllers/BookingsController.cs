using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSE325_team.Data;
using CSE325_team.Models;

namespace CSE325_team.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BookingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Booking>>> GetBookings()
        {
            return await _context.Booking
                .Include(b => b.Vehicle)
                .Include(b => b.User)
                .ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Booking>> CreateBooking(Booking booking)
        {
            // Optional: validate vehicle availability here
            var vehicle = await _context.Vehicle.FindAsync(booking.VehicleId);
            if (vehicle == null || vehicle.Status != "available")
            {
                return BadRequest("Vehicle not available.");
            }

            _context.Booking.Add(booking);

            // Optional: mark vehicle as reserved/rented
            vehicle.Status = "reserved";

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBookings), new { id = booking.BookingId }, booking);
        }
    }
}
