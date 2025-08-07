using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using CSE325_team.Models;

namespace CSE325_team.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    // add custom fields here.
    public string? FirstName { get; set; }
    public string? LastName { get; set; }


    // easier access to client full name
    //not mapped means that it doesn't create the field in the database
    //but we can use it in the project
    [NotMapped]
    public string FullName => $"{FirstName} {LastName}";


    // Navigation property: one user → many bookings
    // this should help with showing all of a client's bookings
    [InverseProperty("User")]
    public ICollection<Models.Booking>? Bookings { get; set; }
    public ICollection<Contact>? Contacts { get; set; }

}
// **************FYI******
//These fields are all inherited from Identity User
// public class IdentityUser
// {
//     public string Id { get; set; }
//     public string UserName { get; set; }
//     public string NormalizedUserName { get; set; }
//     public string Email { get; set; }
//     public string NormalizedEmail { get; set; }
//     public bool EmailConfirmed { get; set; }
//     public string PasswordHash { get; set; }
//     public string SecurityStamp { get; set; }
//     public string ConcurrencyStamp { get; set; }
//     public string PhoneNumber { get; set; }
//     public bool PhoneNumberConfirmed { get; set; }
//     public bool TwoFactorEnabled { get; set; }
//     public DateTimeOffset? LockoutEnd { get; set; }
//     public bool LockoutEnabled { get; set; }
//     public int AccessFailedCount { get; set; }
// }