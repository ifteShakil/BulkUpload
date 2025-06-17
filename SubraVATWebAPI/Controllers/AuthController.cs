using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharedLibrary.DataModel;
using SharedLibrary.DataModel.Authentication;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text; // Adjust namespace as needed

namespace SubraVATWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _config;
        private readonly UserSession userSession = new UserSession();


        public AuthController(ApplicationDbContext context, IConfiguration config, UserSession userSession)
        {
            _context = context;
            _config = config;
            this.userSession = userSession;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var user = _context.tbl_User.FirstOrDefault(u => u.LoginName == request.Username);
            if (user == null) return Unauthorized(new { message = "Invalid username" });

            var userPassword = _context.tbl_UserPassword.FirstOrDefault(p => p.UserID == user.UserID);
            if (userPassword == null || userPassword.Password != request.Password)
                return Unauthorized(new { message = "Invalid username or password" });

            // ✅ Generate JWT Token
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserID.ToString()),
                new Claim(ClaimTypes.Name, user.LoginName),
                // Fix for CS1061: Replace "OCODE" with "OCode" as per the User class definition
                new Claim("OCode", user.OCode ?? "")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetValue<string>("AppSettings:Key")!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _config.GetValue<string>("AppSettings:Issuer"),
                audience: _config.GetValue<string>("AppSettings:Audience"),
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: creds
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            userSession.UserId = user.UserID;
            userSession.OCode = user.OCode;
            //userSession.LoginName = user.LoginName;
            // Success: return user info (never return password)
            return Ok(new
            {
                message = "Login successful",
                userId = user.UserID,
                userName = user.LoginName,
                oCode = user.OCode,
                token = tokenString // Return the JWT token
            });
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // In a typical JWT-based authentication, logout is handled on the client side by removing the token.
            // Optionally, you can implement server-side token blacklisting if needed.
            // Here, just return a success message.
            return Ok(new { message = "Logout successful" });
        }
    }
}