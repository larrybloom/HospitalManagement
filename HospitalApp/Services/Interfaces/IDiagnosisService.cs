using HospitalApp.Model.Entities;

namespace HospitalApp.Services.Interfaces
{
    public interface IDiagnosisService
    {
        Task AddDiagnosisAsync(Diagnosis diagnosis);
        Task<Diagnosis?> GetDiagnosisByIdAsync(string id);
        Task UpdateDiagnosisAsync(Diagnosis diagnosis);
        Task DeleteDiagnosisAsync(string id);
    }
}
