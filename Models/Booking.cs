using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CSE325_team.Data;

namespace CSE325_team.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        public string ClientName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalPrice { get; set; }

        // Relación con Vehicle (antes era Car)
        [ForeignKey("Vehicle")]
        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }

        // Relación con el usuario que hizo la reserva
        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}

