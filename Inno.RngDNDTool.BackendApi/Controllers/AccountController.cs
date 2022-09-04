using AutoMapper;
using Inno.RngDNDTool.Core.DtoModels.Internal.Character;
using Inno.RngDNDTool.Core.DtoModels.Internal.Identity;
using Inno.RngDNDTool.Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Inno.RngDNDTool.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this._configuration = configuration;
            _mapper = mapper;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login()
        {
            var request = ControllerContext.HttpContext.Request;
            var stream = new StreamReader(request.Body);
            var body = await stream.ReadToEndAsync();
            var content = JsonSerializer.Deserialize<LoginDTO>(body.ToString());

            var user = await _userManager.FindByNameAsync(content.UserName);

            if (user != null && await _userManager.CheckPasswordAsync(user, content.Password))
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("UserId", user.Id)
                };

                foreach (var userRole in userRoles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, userRole));
                };

                var token = GetToken(claims);
                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token), expiration = token.ValidTo });
            }
            return BadRequest(new { error = "Could not find account with given credentials." });
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register()
        {
            var request = ControllerContext.HttpContext.Request;
            var stream = new StreamReader(request.Body);
            var body = await stream.ReadToEndAsync();
            var content = JsonSerializer.Deserialize<RegisterDTO>(body.ToString());
            var user = _mapper.Map<ApplicationUser>(content);

            var result = await _userManager.CreateAsync(user, content.Password);

            if (result.Succeeded)
            {
                return Ok(new { status = "Success", message = "Account Created!"});
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(6),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }
    }
}