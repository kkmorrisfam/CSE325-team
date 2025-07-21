using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourApp.Models
{    
    /// Represents a car available for rent.
    
    public class Car
    {
        // Primary key for EF Core. 'Id' is convention-based, but [Key] makes it explicit.
        [Key]
        public int Id { get; set; }

        // The manufacturer or brand name ("Toyota", "Ford").
        [Required]
        public string Brand { get; set; }

        // The classification of the car ("SUV", "Compact").
        // Named CarClass to avoid using the C# keyword 'class'.
        [Required]
        public string CarClass { get; set; }

        // The model name of the car ("Camry", "Mustang").
        [Required]
        public string Model { get; set; }

        // Seating or cargo capacity (number of people or units).
        // Must be at least 1.
        [Range(1, int.MaxValue)]
        public int Capacity { get; set; }

        // Exterior color description ("Red", "Midnight Blue").
        public string Color { get; set; }

        // Rental price per day.
        // Stored as decimal(18,2) in the database to preserve currency precision.
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.0, double.MaxValue)]
        public decimal PricePerDay { get; set; }

        // Indicates whether the car is currently available for booking.
        public bool IsAvailable { get; set; }
    }
}