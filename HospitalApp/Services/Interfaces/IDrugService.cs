using HospitalApp.Model.Entities;

namespace HospitalApp.Services.Interfaces
{
    public interface IDrugService
    {
        Task AddDrugAsync(Drug drug);
        Task<Drug?> GetDrugByIdAsync(string id);
        Task UpdateDrugAsync(Drug drug);
        Task DeleteDrugAsync(string id);
    }
}
