using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSE325_team.Models
{
    /// <summary>
    /// Represents an application user (not IdentityUser, but for business logic).
    /// </summary>
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; } = "";

        [Required]
        public string PasswordHash { get; set; } = "";

        [Required]
        public string FullName { get; set; } = "";

        [Required]
        public string PhoneNumber { get; set; } = "";

        [Required]
        public string Address { get; set; } = "";

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;

        // Optional self-reference for related user
        public int? RelatedUserId { get; set; }
        public User? RelatedUser { get; set; }

        // Navigation: Bookings by user
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();

        // Navigation: Payments by user
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}