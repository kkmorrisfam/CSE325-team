using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSE325_team.Models;
using CSE325_team.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

[Route("api/[controller]")]
[ApiController]
//[Authorize]
[AllowAnonymous]
public class UserProfileController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ApplicationDbContext _context;

    public UserProfileController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
    {
        _userManager = userManager;
        _context = context;
    }


    [HttpGet]
    public async Task<ActionResult<UserContactCombined>> Get()
    {
        //get logged in user
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            Console.WriteLine("User is null — not authenticated.");
            return Unauthorized();
        }

        //get connected contact
        var contact = await _context.Contact.FirstOrDefaultAsync(c => c.ApplicationUserId == user.Id);

Console.WriteLine("User FirstName: " + user?.FirstName);
Console.WriteLine("User Email: " + user?.Email);
        Console.WriteLine("Contact City: " + contact?.City);

// Console.WriteLine("Returned JSON: " + JsonSerializer.Serialize(responseObject));


        //get the data
        return new UserContactCombined
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            PhoneNumber = user?.PhoneNumber,
            AltPhoneNumber = contact?.AltPhoneNumber,
            City = contact?.City
        };
    }

    [HttpPut]
    public async Task<IActionResult> Update(UserContactCombined putUser)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return Unauthorized();

        //replace data
        user.FirstName = putUser.FirstName;
        user.LastName = putUser.LastName;
        user.PhoneNumber = putUser.PhoneNumber;
        //update user
        await _userManager.UpdateAsync(user);

        var contact = await _context.Contact.FirstOrDefaultAsync(c => c.ApplicationUserId == user.Id);
        //if there is no contact linked to user, create one and link it
        if (contact == null)
        {
            contact = new Contact { ApplicationUserId = user.Id };
            _context.Contact.Add(contact);
        }

        contact.AltPhoneNumber = putUser.AltPhoneNumber;
        contact.City = putUser.City;

        await _context.SaveChangesAsync();

        return NoContent();
    }

}