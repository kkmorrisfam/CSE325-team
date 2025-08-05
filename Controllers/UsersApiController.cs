using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using CSE325_team.Models;

namespace CSE325_team.Data
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersApiController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersApiController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        // GET: api/UsersApi
        [HttpGet]
        public ActionResult<IEnumerable<ApplicationUser>> GetAllUsers()
        {
            return Ok(_userManager.Users.ToList());
        }

        // GET: api/UsersApi/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationUser>> GetUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        // // POST: api/UsersApi
        // [HttpPost]
        // public async Task<ActionResult<ApplicationUser>> CreateUser(ApplicationUser user)
        // {
        //     var result = await _userManager.CreateAsync(user, "DefaultPassword123!"); // Replace with real password logic
        //     if (!result.Succeeded) return BadRequest(result.Errors);
        //     return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        // }

        // DELETE: api/UsersApi/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            var result = await _userManager.DeleteAsync(user);
            if (!result.Succeeded) return BadRequest(result.Errors);
            return NoContent();
        }
    }
}