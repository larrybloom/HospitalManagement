using HospitalApp.Model.Entities;

namespace HospitalApp.Services.Interfaces
{
    public interface IDrugMedicationService
    {
        Task AddDrugMedicationAsync(DrugMedication drugMedication);
        Task<DrugMedication?> GetDrugMedicationByIdAsync(string id);
        Task UpdateDrugMedicationAsync(DrugMedication drugMedication);
        Task DeleteDrugMedicationAsync(string id);
    }
}
