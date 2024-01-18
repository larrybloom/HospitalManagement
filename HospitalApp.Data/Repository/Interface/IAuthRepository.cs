using HospitalApp.Model.DTOs;
using HospitalApp.Model.DTOs.AuthenticationDTOs;
using HospitalApp.Model.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Data.Repository.Interface
{
    public interface IAuthRepository
    {
        Task<User> SignUpAsync(User user, string Password);
        Task<bool> CheckAccountPassword(User user, string password);
        int GenerateConfirmEmailToken();
        Task<bool> DeleteUserToken(ConfirmEmailToken token);
        Task<ConfirmEmailToken> retrieveUserToken(string userid);
        Task<ConfirmEmailToken> SaveGenerateConfirmEmailToken(ConfirmEmailToken emailToken);
        Task<bool> CheckEmailConfirmed(User user);
        Task<bool> AddRoleAsync(User user, string Role);
        Task<string> ForgotPassword(User user);
        Task<bool> ConfirmEmail(string token, User user);
        Task<bool> RemoveRoleAsync(User user, IList<string> role);
        Task<ResetPassword> ResetPasswordAsync(User user, ResetPassword resetPassword);
        Task<bool> RoleExist(string Role);
        Task<User?> FindUserByEmailAsync(string email);
        Task<User> FindUserByIdAsync(string id);
        Task<bool> UpdateUserInfo(User applicationUser);
        Task<IList<string>> GetUserRoles(User user);
        Task<bool> DeleteUserByEmail(User user);
    }
}
