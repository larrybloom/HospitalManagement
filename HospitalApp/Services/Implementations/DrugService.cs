using HospitalApp.Data.Repository.Interface;
using HospitalApp.Model.Entities;
using HospitalApp.Services.Interfaces;

namespace HospitalApp.Services.Implementations
{
    public class DrugService : IDrugService
    {
        private readonly IRepository<Drug> _repository;

        public DrugService(IRepository<Drug> repository)
        {
            _repository = repository;
        }

        public async Task AddDrugAsync(Drug drug)
        {
            if (drug == null)
                throw new ArgumentNullException(nameof(drug));

            await _repository.AddAsync(drug);
        }

        public async Task<Drug?> GetDrugByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateDrugAsync(Drug drug)
        {
            if (drug == null)
                throw new ArgumentNullException(nameof(drug));

            await _repository.UpdateAsync(drug);
        }

        public async Task DeleteDrugAsync(string id)
        {
            var drug = await _repository.GetByIdAsync(id);
            if (drug != null)
            {
                await _repository.DeleteAsync(drug);
            }
        }
    }
}
