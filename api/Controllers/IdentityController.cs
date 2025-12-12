namespace Api.Controllers;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public class IdentityController(
    SignInManager<IdentityUser> signInManager
) : ControllerBase
{

    [HttpPost("logout")]
    public async Task<IActionResult> Logout(
        [FromBody] object empty
    )
    {
        if (empty != null)
        {
            await signInManager.SignOutAsync();
            return Ok();
        }

        return Unauthorized();
    }
}
