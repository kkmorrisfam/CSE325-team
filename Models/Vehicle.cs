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

        // ——— Required text fields ———
        [Required, MaxLength(100)]
        public string Make { get; set; } = default!;

        [Required, MaxLength(100)]
        public string Model { get; set; } = default!;

        [Required, MaxLength(40)]
        public string Color { get; set; } = default!;

        // ——— Numbers ———
        [Range(1900, 2100, ErrorMessage = "Year must be between 1900 and 2100.")]
        public int? Year { get; set; } // make this non-nullable if you want it required

        [Range(0, 20, ErrorMessage = "Seats must be between 0 and 20.")]
        public int? Seats { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Mileage cannot be negative.")]
        public int? Mileage { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Price must be non-negative.")]
        public decimal Price { get; set; }

        // ——— Enums ———
        [Required]
        public VehicleCategory Category { get; set; }

        [Required]
        public TransmissionType Transmission { get; set; }

        [Required]
        public FuelType FuelType { get; set; }

        [Required]
        public VehicleStatus Status { get; set; }
    }

    
    public enum VehicleCategory
    {
        Coupe,
        Sedan,
        Truck,
        Motorcycle,
        Luxury,
    }

    public enum TransmissionType
    {
        Automatic,
        Manual
    }

    public enum FuelType
    {
        Gasoline,
        Electric,
    }

    public enum VehicleStatus
    {
        Available,
        Rented,
        Reserved,
        Maintenance
    }
}