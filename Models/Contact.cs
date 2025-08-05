//to see user information, go to Data/ApplicationUser.cs
using System.ComponentModel.DataAnnotations;
using CSE325_team.Data;

namespace CSE325_team.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        [RegularExpression(@"^([+]?\d{1,2}[-\s]?|)\d{3}[-\s]?\d{3}[-\s]?\d{4}$")]
        public string? PhoneNumber { get; set; }

        [MinLength(5), MaxLength(100)]
        public string? StreetLine1 { get; set; }

        [MaxLength(100)]
        public string? StreetLine2 { get; set; }

        [MinLength(3), MaxLength(50)]
        public string? City { get; set; }

        [MinLength(3), MaxLength(30)]
        public string? State { get; set; }

        [RegularExpression(@"^([0-9]{5})$")]
        public string? PostalCode { get; set; }



        //foreign key to ApplicationUser
        public string ApplicationUserId { get; set; } = default!;
        public ApplicationUser ApplicationUser { get; set; } = default!;

    }
}
