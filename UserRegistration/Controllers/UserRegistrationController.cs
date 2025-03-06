using System.Security.Claims;
using BusinessLayer.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;
using NLog;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly IUserRegistrationBL _userRegistrationBL;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public UserRegistrationController(IUserRegistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;
        }

        [HttpPost("login")]
        public IActionResult LoginUser(LoginDTO loginDTO)
        {
            var (token, isCached) = _userRegistrationBL.loginBL(loginDTO);

            if (token == null)
            {
                return Unauthorized(new { Success = false, Message = "Invalid email or password" });
            }

            var response = new ResponseModel<LoginResponse>
            {
                Success = true,
                Message = "Login Successful",
                Data = new LoginResponse
                {
                    Email = loginDTO.Email,
                    Token = token,
                    Cached = isCached 
                }
            };

            return Ok(response);
        }

        [HttpPost("Register")]
        public IActionResult RegisterUser(UserDTO user)
        {
            try
            {
                var result = _userRegistrationBL.RegisterUser(user);

                if (result)
                {
                    logger.Info("User registered successfully.");
                    return Ok(new
                    {
                        Success = true,
                        Message = "User registered successfully. Redis cache cleared for this email."
                    });
                }
                else
                {
                    return BadRequest(new { Success = false, Message = "User registration failed" });
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error while registering user.");
                return StatusCode(500, new { Success = false, Message = "Internal Server Error" });
            }
        }

        [Authorize]
        [HttpGet("profile")]
        public IActionResult GetUserProfile()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity == null)
            {
                return Unauthorized(new { Success = false, Message = "Unauthorized access" });
            }

            var claims = identity.Claims;
            int id = int.Parse(claims.FirstOrDefault(c => c.Type == "ID")?.Value);
            string firstName = claims.FirstOrDefault(c => c.Type == "FirstName")?.Value;
            string lastName = claims.FirstOrDefault(c => c.Type == "LastName")?.Value;
            string email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;

            return Ok(new
            {
                Success = true,
                Message = "User details retrieved",
                Data = new { ID = id, FirstName = firstName, LastName = lastName, Email = email }
            });
        }
    }
}
