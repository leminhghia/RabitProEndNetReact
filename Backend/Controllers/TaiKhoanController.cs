using Azure.Identity;
using Backend.DTOs;
using Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    public class TaiKhoanController(SignInManager<User> signInManager) : ApiController
    {
        [HttpPost("register")]
        public async Task<ActionResult> RegisterUser(RegisterDto dto)
        {
            var user = new User { UserName = dto.Email, Email = dto.Email };

            var result = await signInManager.UserManager.CreateAsync(user,dto.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return ValidationProblem();
            }
            await signInManager.UserManager.AddToRoleAsync(user, "Member");
            return Ok();
        }
        [HttpGet("user-info")]
        public async Task<ActionResult> GetUserInfo()
        {
            if (User.Identity?.IsAuthenticated == false) return NoContent();

            var user = await signInManager.UserManager.GetUserAsync(User);

            if (user == null) return Unauthorized();

            var roles = await signInManager.UserManager.GetRolesAsync(user);

            return Ok(new
            {
                user.Email,
                user.UserName,
                Roles = roles
            });
        }
        [HttpPost("logout")]
        public async Task<ActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return NoContent();
        }
    }
}
