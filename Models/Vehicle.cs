using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSE325_team.Models
{
    /// <summary>
    /// Represents a vehicle available for rent.
    /// </summary>
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }

        [Required]
        public string Make { get; set; } = "";

        [Required]
        public string Model { get; set; } = "";

        public int? Year { get; set; }

        [Required]
        public string Color { get; set; } = "";

        [Required]
        public string VehicleType { get; set; } = "";

        [Required]
        public string Transmission { get; set; } = "";

        [Column(TypeName = "decimal(10,2)")]
        [Range(0.0, double.MaxValue)]
        public decimal DailyRate { get; set; }

        public string? ImageFileName { get; set; }

        public string? FuelType { get; set; }

        public int? Seats { get; set; }

        [MaxLength(20)]
        public string? LicensePlate { get; set; }

        public int? Mileage { get; set; }

        [Required]
        [RegularExpression("available|rented|reserved|maintenance", ErrorMessage = "Invalid status")]
        public string Status { get; set; } = "available";

        [Range(1, int.MaxValue)]
        public int Capacity { get; set; }

        // Navigation: Bookings for this vehicle
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}