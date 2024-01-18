using HospitalApp.Model.DTOs;
using HospitalApp.Model.DTOs.AuthenticationDTOs;
using HospitalApp.Model.Entities;

namespace HospitalApp.Interfaces
{
    public interface IAuthService
    {
        Task<ResponseDto<string>> RegisterAsync(RegisterDto registerDto, List<string> roles);
        Task<ResponseDto<LoginDto>> LoginAsync(LoginDto loginDto);

        Task<ResponseDto<string>> ForgotPasswordAsync(string userEmail);
        Task<ResponseDto<string>> ResetPasswordAsync(ResetPassword newPassword);
        Task<ResponseDto<string>> ConfirmEmailAsync(int token, string email);

    }
}