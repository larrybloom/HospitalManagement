using HospitalApp.Data.Repository.Interface;
using HospitalApp.Model.Entities;
using HospitalApp.Services.Interfaces;

namespace HospitalApp.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task AddUserAsync(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            await _repository.AddAsync(user);
        }

        public async Task<User?> GetUserByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateUserAsync(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            await _repository.UpdateAsync(user);
        }

        public async Task DeleteUserAsync(string id)
        {
            var user = await _repository.GetByIdAsync(id);
            if (user != null)
            {
                await _repository.DeleteAsync(user);
            }
        }
    }
}
