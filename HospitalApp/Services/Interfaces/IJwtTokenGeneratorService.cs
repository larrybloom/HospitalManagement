

using HospitalApp.Model.Entities;

namespace HospitalApp.Services.Interfaces
{
    public interface IJwtTokenGeneratorService
    {

        Task <string> GenerateToken(User user);
    }
}