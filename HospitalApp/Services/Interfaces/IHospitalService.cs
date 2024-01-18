using HospitalApp.Model.Entities;

namespace HospitalApp.Services.Interfaces
{
    public interface IHospitalService
    {
        Task AddHospitalAsync(Hospital hospital);
        Task<Hospital?> GetHospitalByIdAsync(int id);
        Task UpdateHospitalAsync(Hospital hospital);
        Task DeleteHospitalAsync(int id);
    }
}
