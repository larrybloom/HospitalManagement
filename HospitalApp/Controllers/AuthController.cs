using HospitalApp.Interfaces;
using HospitalApp.Model.DTOs;
using HospitalApp.Model.DTOs.AuthenticationDTOs;
using Microsoft.AspNetCore.Mvc;



namespace HospitalApp.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto, [FromQuery] List<string> roles)
        {
            var response = await _authService.RegisterAsync(registerDto, roles);

            if (response.StatusCode == 200)
            {
                return Created("", response);
            }
            else if (response.StatusCode == 201)
            {
                return Created("", response);
            }
            else if (response.StatusCode == 400)
            {
                return BadRequest(response);
            }
            else if (response.StatusCode == 500)
            {
                return StatusCode(500, response);
            }
            else
            {
                return StatusCode(response.StatusCode, response.ErrorMessage);
            }
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var result = await _authService.LoginAsync(loginDto);

            if (result.StatusCode == 200)
            {
                return Ok(result);
            }
            else if (result.StatusCode == 404)
            {
                return NotFound(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto forgotPasswordDto)
        {
            var result = await _authService.ForgotPasswordAsync(forgotPasswordDto.Email);

            if (result.StatusCode == 200)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPassword resetPasswordDto)
        {
            var result = await _authService.ResetPasswordAsync(resetPasswordDto);

            if (result.StatusCode == 200)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Confirm-email")]
        public async Task<IActionResult> ConfirmEmail(ConfirmEmailTokenDto token, string email)
        {
            var result = await _authService.ConfirmEmailAsync(token.token, email);
            if (result.StatusCode == 200)
            {
                return Ok(result);
            }
            else if (result.StatusCode == 404)
            {
                return NotFound(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

    }
}
