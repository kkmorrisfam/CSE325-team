using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CSE325_team.Models; 
public class Booking
{
    public int BookingId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal TotalPrice { get; set; }
    public int UserId { get; set; }
    public int VehicleId { get; set; }

    // Navigation properties
    public User User { get; set; }
    public Vehicle Vehicle { get; set; }

}