using HospitalApp.Model.Entities;

namespace HospitalApp.Services.Interfaces
{
    public interface IMedicationService
    {
        Task AddMedicationAsync(Medication medication);
        Task<Medication?> GetMedicationByIdAsync(string id);
        Task UpdateMedicationAsync(Medication medication);
        Task DeleteMedicationAsync(string id);
    }
}
