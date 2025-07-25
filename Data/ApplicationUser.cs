using Microsoft.AspNetCore.Identity;

namespace CSE325_team.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    // add custom fields here.
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}

