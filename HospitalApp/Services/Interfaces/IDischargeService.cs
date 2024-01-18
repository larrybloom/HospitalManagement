using HospitalApp.Model.Entities;

namespace HospitalApp.Services.Interfaces
{
    public interface IDischargeService
    {
        Task AddDischargeAsync(Discharge discharge);
        Task<Discharge?> GetDischargeByIdAsync(string id);
        Task UpdateDischargeAsync(Discharge discharge);
        Task DeleteDischargeAsync(string id);
    }
}
