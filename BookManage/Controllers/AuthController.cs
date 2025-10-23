using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BookManage.cs.Data.Context;
using BookManage.cs.Data.Entities;
using BookManage.Data.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    //private readonly UserManager<User> _userManager;
    public readonly MyDbContext _context;
    private readonly IConfiguration _configuration;

    //public AuthController(UserManager<User> userManager, IConfiguration configuration)
    //{
    //    _userManager = userManager;
    //    _configuration = configuration;
    //}

    public AuthController(MyDbContext context)
    {
        _context = context; 
    }

    // Login DTO: Must contain Username/Email and Password
    // public class LoginDto { public string Username { get; set; } public string Password { get; set; } }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] Login model)
    {
        // 1. Validate Credentials
        var user = await _context.users.FindAsync(model.username);
        if (user == null )
        {
            return Unauthorized("Invalid Username.");
        }

        string dbPass = user.password;
        Console.WriteLine(dbPass);
        Console.WriteLine(model.password);
        if(user.password != model.password)
        {
            return Unauthorized("Invalid Password.");
        }

        // 2. Generate Token
        //var token = GenerateJwtToken(user);

        var token = "keinikn";

        // 3. Return Token to Client
        return Ok();
    }

    private JwtSecurityToken GenerateJwtToken(User user)
    {
        // Claims are the user's identity data stored in the token payload
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.user_id.ToString()), // Convert int to string
            new Claim(ClaimTypes.Name, user.username),     // Use username
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()) // JWT ID
        };

        // In a real app, you would add roles here:
        // var roles = await _userManager.GetRolesAsync(user);
        // claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

        var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

        var token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            expires: DateTime.Now.AddHours(1), // Token expiry time (e.g., 1 hour)
            claims: claims,
            signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
        );

        return token;
    }
}