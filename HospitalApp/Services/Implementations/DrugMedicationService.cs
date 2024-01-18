using HospitalApp.Data.Repository.Interface;
using HospitalApp.Model.Entities;
using HospitalApp.Services.Interfaces;

namespace HospitalApp.Services.Implementations
{
    public class DrugMedicationService : IDrugMedicationService
    {
        private readonly IRepository<DrugMedication> _repository;

        public DrugMedicationService(IRepository<DrugMedication> repository)
        {
            _repository = repository;
        }

        public async Task AddDrugMedicationAsync(DrugMedication drugMedication)
        {
            if (drugMedication == null)
                throw new ArgumentNullException(nameof(drugMedication));

            await _repository.AddAsync(drugMedication);
        }

        public async Task<DrugMedication?> GetDrugMedicationByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateDrugMedicationAsync(DrugMedication drugMedication)
        {
            if (drugMedication == null)
                throw new ArgumentNullException(nameof(drugMedication));

            await _repository.UpdateAsync(drugMedication);
        }

        public async Task DeleteDrugMedicationAsync(string id)
        {
            var drugMedication = await _repository.GetByIdAsync(id);
            if (drugMedication != null)
            {
                await _repository.DeleteAsync(drugMedication);
            }
        }
    }
}
