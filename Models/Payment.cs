using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CSE325_team.Data;

namespace CSE325_team.Models
{
    /// <summary>
    /// Represents a payment for a booking.
    /// </summary>
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [DataType(DataType.Date)]
        public DateTime PaymentAt { get; set; } = DateTime.UtcNow;

        [Column(TypeName = "decimal(10,2)")]
        [Range(0.01, double.MaxValue)]
        public decimal Amount { get; set; }

        [Required]
        public string PaymentMethod { get; set; } = "";

        [Required]
        public string State { get; set; } = "";

        [Required, MaxLength(10)]
        public string Zip { get; set; } = "";

        // Foreign key to User
        [Required]
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

        // Optional: Link to Booking
        public int? BookingId { get; set; }
        public Booking? Booking { get; set; }

        [Required]
        public string Status { get; set; } = "Pending"; // Default status 

        [NotMapped]
        public static string[] StatusOptions { get; } = new[] { "Pending", "Completed", "Failed", "Refunded" };
    }
}