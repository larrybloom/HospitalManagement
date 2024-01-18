using HospitalApp.Model.Entities;

namespace HospitalApp.Services.Interfaces
{
    public interface ILabTestService
    {
        Task AddLabTestAsync(LaboratoryTest labTest);
        Task<LaboratoryTest?> GetLabTestByIdAsync(string id);
        Task UpdateLabTestAsync(LaboratoryTest labTest);
        Task DeleteLabTestAsync(string id);
    }
}
