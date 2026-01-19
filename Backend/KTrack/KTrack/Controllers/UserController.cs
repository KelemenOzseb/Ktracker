using Data.Repository;
using Entities.Dtos.User;
using Entities.Models;
using Logic.Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;

namespace KTrack.Controllers
{
    public class UserController : ControllerBase
    {
        UserManager<User> userManager;
        DtoProvider dtoProvider;
        public UserController(UserManager<User> userManager, DtoProvider dtoProvider)
        {
            this.userManager = userManager;
            this.dtoProvider = dtoProvider;
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        [HttpPost("Register")]
        public async Task RegisterUser(RegistrationDto dto)
        {
            if (dto.Password.Length < 8) throw new ArgumentException("The password must be at least 8 characters long");

            if (await userManager.FindByEmailAsync(dto.Email) != null) throw new ArgumentException("Profile with this email already exists");

            if (await userManager.FindByNameAsync(dto.UserName) != null) throw new ArgumentException("Profile with this username already exists");

            if (!(IsValidEmail(dto.Email))) throw new ArgumentException("The email address format is invalid");

            await userManager.CreateAsync(dtoProvider.Mapper.Map<User>(dto), dto.Password);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            if (string.IsNullOrEmpty(dto.UserName) && string.IsNullOrEmpty(dto.Email))
            {
                return BadRequest("Username or email must be provided");
            }
            var user = new User();
            if (string.IsNullOrEmpty(dto.UserName))
            {
                user = await userManager.FindByEmailAsync(dto.Email);
            }
            else
            {
                user = await userManager.FindByNameAsync(dto.UserName);
            }
            if (user == null)
            {
                return BadRequest("User not found");
            }
            else
            {
                var result = await userManager.CheckPasswordAsync(user, dto.Password);
                if (!result)
                {
                    return BadRequest("Invalid password");
                }
                else
                {
                    //todo: generate token
                    var claim = new List<Claim>();
                    claim.Add(new Claim(ClaimTypes.Name, user.UserName!));
                    claim.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));

                    int expiryInMinutes = 24 * 60;
                    var token = GenerateAccessToken(claim, expiryInMinutes);

                    return Ok(new LoginResultDto()
                    {
                        Token = new JwtSecurityTokenHandler().WriteToken(token),
                        Expiration = DateTime.Now.AddMinutes(expiryInMinutes)
                    });
                }
            }
        }

        private JwtSecurityToken GenerateAccessToken(IEnumerable<Claim>? claims, int expiryInMinutes)
        {
            var signinKey = new SymmetricSecurityKey(
                  Encoding.UTF8.GetBytes("NagyonhosszútitkosítókulcsNagyonhosszútitkosítókulcsNagyonhosszútitkosítókulcsNagyonhosszútitkosítókulcsNagyonhosszútitkosítókulcsNagyonhosszútitkosítókulcs"));

            return new JwtSecurityToken(
                  issuer: "movieclub.com",
                  audience: "movieclub.com",
                  claims: claims?.ToArray(),
                  expires: DateTime.Now.AddMinutes(expiryInMinutes),
                  signingCredentials: new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256)
                );
        }

    }
}
