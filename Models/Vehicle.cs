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
        public int VehicleId { get; set; }

        // Manufacturer or brand (e.g., Toyota, Ford)
        [Required]
        public required string Make { get; set; }

        // Model (e.g., Camry, Mustang)
        [Required]
        public required string Model { get; set; }


        // Year of manufacture
        public int? Year { get; set; }

        // Unique license plate number

        // Exterior color
        [Required]
        public required string Color { get; set; }

        [Required]
        public required string VehicleType { get; set; }

        [Required]
        public required string Transmission { get; set; }


        // Daily rental rate
        [Column(TypeName = "decimal(10,2)")]
        [Range(0.0, double.MaxValue)]
        public decimal DailyRate { get; set; }

        public string? ImageFileName { get; set; }

        public string? FuelType { get; set; }

        public int? Seats { get; set; }
        [MaxLength(20)]
        public string? LicensePlate { get; set; }

        
        public int? Mileage { get; set; }

        // Vehicle status (available, rented, reserved, maintenance)
        [Required]
        [RegularExpression("available|rented|reserved|maintenance", ErrorMessage = "Invalid status")]
        public required string Status { get; set; }


        // Seating or cargo capacity
        [Range(1, int.MaxValue)]
        public int Capacity { get; set; }


        public Vehicle()
        {
            Make = "";
            Model = "";
            Color = "";
            Status = "available";
            VehicleType = "";
            Transmission = "";
        }
    }
}
