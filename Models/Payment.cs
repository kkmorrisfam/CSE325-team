using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CSE325_team.Data;

namespace CSE325_team.Models
{
    public class Payment
    {
        [Key]
public int PaymentId { get; set; }

        [DataType(DataType.Date)]
        public DateTime PaymentAt { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        [Range(0.01, double.MaxValue)]
        public decimal Amount { get; set; }

        [Required]
        public string PaymentMethod { get; set; } = string.Empty;

        [Required]
        public string State { get; set; } = string.Empty;

        [Required]
        [MaxLength(10)]
        public string Zip { get; set; } = string.Empty;

        // Foreign key to User
        [Required]

        public required ApplicationUser User { get; set; }

        // Optional: Link to Booking
        public int? BookingId { get; set; }
        public Booking? Booking { get; set; }

        [Required]

        // Status list of options
        public string Status { get; set; } = "Pending"; // Default status 
        public static string[] StatusOptions { get; } = ["Pending", "Completed", "Failed", "Refunded"];



    }
}