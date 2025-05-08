using Lea.Service.DTOs;
using Lea.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace Lea.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("sign-in")]
        public async Task<IActionResult> GenerateToken([FromBody] string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return BadRequest("Email is required.");
            }
            try
            {
                var status = await _authenticationService.SendOtpAsync(email);
                return Ok(new { EmailSent = status });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("verify-otp")]
        public async Task<IActionResult> VerifyToken([FromBody] string token, [FromBody] string email)
        {
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest("otp is required.");
            }
            try
            {
                var isValid = await _authenticationService.VerifyOtpAsync(token, email);
                if (isValid)
                {
                    return Ok(new APIResponseDto<bool>
                    {
                        StatusCode = StatusCodes.Status200OK,
                        Data = isValid,
                        Message = "otp verification successful."
                    });
                }
                else
                {
                    return Unauthorized("Invalid otp.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }
    }
}
