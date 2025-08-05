using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSE325_team.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }

        [Required(ErrorMessage = "Make is required")]
        public string Make { get; set; } = string.Empty;

        [Required(ErrorMessage = "Model is required")]
        public string Model { get; set; } = string.Empty;

        public int? Year { get; set; }

        [Required(ErrorMessage = "Color is required")]
        public string Color { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vehicle Type is required")]
        public string VehicleType { get; set; } = string.Empty;

        [Required(ErrorMessage = "Transmission is required")]
        public string Transmission { get; set; } = string.Empty;

        public string FuelType { get; set; } = string.Empty;

        [Range(0.01, 1000, ErrorMessage = "Daily Rate must be positive")]
        public decimal DailyRate { get; set; }

        [Range(1, 20, ErrorMessage = "Capacity is required")]
        public int Capacity { get; set; }

        public int Mileage { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; } = string.Empty;

        public string ImageFileName { get; set; } = "default.png";

        public int Seats { get; set; } = 4;
    }
}
