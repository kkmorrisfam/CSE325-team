using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSE325_team.Data;

namespace CSE325_team.Controllers;

[ApiController]
[Route("test")]
public class TestController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public TestController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet("bookings/{id:int}")]
    public async Task<IActionResult> GetBooking(int id)
    {
        var booking = await _context.Booking
            .Include(b => b.User)
            .Include(b => b.Vehicle)
            .FirstOrDefaultAsync(b => b.BookingId == id);

        if (booking == null)
            return NotFound($"No booking found with ID {id}");

        return Ok(new
        {
            booking.BookingId,
            booking.StartDate,
            booking.EndDate,
            booking.TotalPrice,
            User = booking.User?.Email,
            Vehicle = $"{booking.Vehicle?.Make} {booking.Vehicle?.Model}",
            ImageFileName = booking.Vehicle?.ImageFileName
        });
    }

    [HttpGet("pricing/{id:int}")]
    public async Task<IActionResult> GetVehiclePricing(int id)
    {
        var vehicle = await _context.Vehicle.FirstOrDefaultAsync(v => v.VehicleId == id);

        if (vehicle == null)
            return NotFound($"No vehicle found with ID {id}");

        return Ok(new
        {
            vehicle.VehicleId,
            vehicle.Make,
            vehicle.Model,
            vehicle.DailyRate
        });
    }
    [HttpGet("booking")]
    public async Task<IActionResult> GetAllBookings()
    {
        var bookings = await _context.Booking
            .Include(b => b.User)
            .Include(b => b.Vehicle)
            .ToListAsync();

        var result = bookings.Select(b => new
        {
            b.BookingId,
            b.StartDate,
            b.EndDate,
            b.TotalPrice,
            User = b.User?.Email,
            Vehicle = $"{b.Vehicle?.Make} {b.Vehicle?.Model}",
            ImageFileName = b.Vehicle?.ImageFileName
        });

        return Ok(result);
    }

    [HttpGet("vehicle")]
    public async Task<IActionResult> GetAllVehicles()
    {
        var vehicles = await _context.Vehicle.ToListAsync();

        return Ok(vehicles.Select(v => new
        {
            v.VehicleId,
            v.Make,
            v.Model,
            v.Year,
            v.VehicleType,
            v.DailyRate,
            v.Status,
            v.ImageFileName,
            v.Transmission,
            v.Capacity,
            v.Mileage,
            v.FuelType
        }));
    }

    [HttpGet("pricing")]
    public async Task<IActionResult> GetAllVehiclePricing()
    {
        var pricing = await _context.Vehicle
            .Select(v => new
            {
                v.VehicleId,
                v.Make,
                v.Model,
                v.DailyRate
            })
            .ToListAsync();

        return Ok(pricing);
    }
}