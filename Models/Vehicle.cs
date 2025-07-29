using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSE325_team.Models
{
    /// <summary>
    /// Represents a vehicle available for rent.
    /// </summary>
    public class Vehicle
    {
        // Primary key, matches SQL schema
        [Key]
        public int VehicleID { get; set; }

        // Manufacturer or brand (e.g., Toyota, Ford)
        [Required]
        public required string Make { get; set; }

        // Model (e.g., Camry, Mustang)
        [Required]
        public required string Model { get; set; }

        // Year of manufacture
        public int? Year { get; set; }

        // Unique license plate number
        [MaxLength(20)]
        public string? LicensePlate { get; set; }

        // Total mileage of the vehicle
        public int? Mileage { get; set; }

        // Vehicle status (available, rented, reserved, maintenance)
        [Required]
        [RegularExpression("available|rented|reserved|maintenance", ErrorMessage = "Invalid status")]
        public required string Status { get; set; }

        // Daily rental rate
        [Column(TypeName = "decimal(10,2)")]
        [Range(0.0, double.MaxValue)]
        public decimal DailyRate { get; set; }

        // Classification of the car (e.g., SUV, Compact)
        [Required]
        public required string CarClass { get; set; }

        // Seating or cargo capacity
        [Range(1, int.MaxValue)]
        public int Capacity { get; set; }

        // Exterior color
        [Required]
        public required string Color { get; set; }
    }
}
