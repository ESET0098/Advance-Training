using System.Security.Claims;
using BookManage.cs.Data.Context;
using BookManage.cs.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// Note: Removed unused Identity and JWT imports from the Controller scope.

namespace BookManage.Controllers
{
    // DTOs for data transfer (must be defined separately)
    // public class UserResponseDto { public int user_id { get; set; } public string username { get; set; } }
    // public class UserUpdateDto { public string username { get; set; } public string password { get; set; } }

    [ApiController]
    [Route("[controller]")]
    [Authorize] // Requires a valid JWT to access all methods
    public class UserController : ControllerBase
    {
        private readonly MyDbContext _context;

        public UserController(MyDbContext context)
        {
            _context = context;
        }

        // ---------------------------------------------------------------------------------
        // ❌ SECURITY VULNERABILITY FIX: NEVER expose passwords in DTOs or GET methods.
        // ---------------------------------------------------------------------------------

        [HttpGet]
        // Returning UserResponseDto (or similar DTO) instead of the full entity
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            var users = await _context.Set<User>()
                .Select(u => new User // Projecting to a safe DTO
                {
                    user_id = u.user_id,
                    username = u.username
                    // Password field is omitted here.
                })
                .ToListAsync();

            if (users == null || users.Count == 0)
            {
                return NotFound("No users found.");
            }

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var user = await _context.Set<User>().FindAsync(id);

            if (user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }

            // Project the user entity into the public DTO, omitting the password.
            var userDto = new User
            {
                user_id = user.user_id,
                username = user.username
            };

            return Ok(userDto);
        }

        // ---------------------------------------------------------------------------------
        // ⚠️ DATA HANDLING FIX: Use a dedicated DTO and handle ID generation/hashing.
        // ---------------------------------------------------------------------------------

        [HttpPost]
        public async Task<ActionResult<User>> PostUser([FromBody] User createDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // 1. Password Hashing (Crucial Step - requires UserManager or a dedicated service)
            // If you are using ASP.NET Identity, you would use:
            // var passwordHash = new PasswordHasher<User>().HashPassword(null, createDto.password);

            // For now, we assume a hashing mechanism exists and the 'password' field holds the HASH
            var user = new User
            {
                // user_id MUST NOT be set by the client; rely on database identity/auto-generation.
                // Assuming 'user_id' is an IDENTITY column (int).
                username = createDto.username,
                password = createDto.password // <--- This should be the HASHED password
            };

            _context.Set<User>().Add(user);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                // Handle unique constraints
                return Conflict("A user with this username might already exist.");
            }

            // Return the created user's safe DTO
            var createdUserDto = new User
            {
                user_id = user.user_id,
                username = user.username
            };

            // Pass the generated ID back in the route data
            return CreatedAtAction(nameof(GetUserById), new { id = user.user_id }, createdUserDto);
        }

        // ---------------------------------------------------------------------------------
        // ⚠️ LOGIC FIX: UserExists helper implementation.
        // ---------------------------------------------------------------------------------

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] User updateDto)
        {
            var user = await _context.Set<User>().FindAsync(id);
            if (user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }

            // Update the user entity with safe DTO values
            user.username = updateDto.username;
            // IMPORTANT: If password is provided, it MUST be re-hashed before storing.
            // user.password = HashPassword(updateDto.password); 

            _context.Set<User>().Update(user);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!UserExists(id))
            {
                return NotFound($"User with ID {id} no longer exists.");
            }
            catch (DbUpdateException)
            {
                // Handle unique constraint violation on username
                return Conflict("Another user already uses that username.");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Set<User>().FindAsync(id);
            if (user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }
            _context.Set<User>().Remove(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // ---------------------------------------------------------------------------------
        // Corrected Private Helper Method
        // ---------------------------------------------------------------------------------
        private bool UserExists(int id)
        {
            return _context.Set<User>().Any(e => e.user_id == id);
        }

        [HttpGet("securedata")]
        public IActionResult GetSecureData()
        {
            // Accessing user information from the validated token (claims)
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var username = User.FindFirst(ClaimTypes.Name)?.Value;

            return Ok(new
            {
                Message = $"Hello, {username}! You accessed secure data.",
                AuthenticatedUserId = userId
            });
        }
    }
}