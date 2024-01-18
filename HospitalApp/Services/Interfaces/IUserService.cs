using HospitalApp.Model.Entities;

namespace HospitalApp.Services.Interfaces
{
    public interface IUserService
    {
        Task AddUserAsync(User user);
        Task<User?> GetUserByIdAsync(string id);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(string id);
    }
}
