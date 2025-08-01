using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CSE325_team.Data;

namespace CSE325_team.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
  
        [Required]

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalPrice { get; set; }

        // Relación con Vehicle (antes era Car)
        public required Vehicle Vehicle { get; set; }

        // Relación con el usuario que hizo la reserva
        [ForeignKey("User")][Required]
        public required string UserId { get; set; }
        public required ApplicationUser User { get; set; }
    }
}
