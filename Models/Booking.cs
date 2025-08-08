using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CSE325_team.Data; // Para ApplicationUser

namespace CSE325_team.Models
{
    /// <summary>
    /// Represents a reservation/booking for a vehicle.
    /// </summary>
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [Required]
        public int VehicleId { get; set; }

        [ForeignKey(nameof(VehicleId))]
        public Vehicle Vehicle { get; set; } = null!;

        [Required]
        [DataType(DataType.Date)]
        public DateTime PickupDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DateGreaterThan("PickupDate", ErrorMessage = "La fecha de entrega debe ser posterior a la de recogida.")]
        public DateTime DropOffDate { get; set; }

        // Foreign key to ApplicationUser (Identity)
        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; } = null!;

        [Column(TypeName = "decimal(10,2)")]
        [Required]
        [Range(0.0, double.MaxValue)]
        public decimal TotalPrice { get; set; }

        // Optional payment navigation
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }

    /// <summary>
    /// Custom validation to ensure DropOffDate is after PickupDate.
    /// </summary>
    public class DateGreaterThanAttribute : ValidationAttribute
    {
        private readonly string _comparisonProperty;

        public DateGreaterThanAttribute(string comparisonProperty)
        {
            _comparisonProperty = comparisonProperty;
        }

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            var property = validationContext.ObjectType.GetProperty(_comparisonProperty);
            var comparisonValue = property?.GetValue(validationContext.ObjectInstance);

            if (value is DateTime dateValue && comparisonValue is DateTime pickupDate)
            {
                if (dateValue <= pickupDate)
                {
                    return new ValidationResult(ErrorMessage);
                }
            }
            return ValidationResult.Success;
        }
    }
}