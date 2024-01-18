using HospitalApp.Data.Repository.Interface;
using HospitalApp.Model.Entities;
using HospitalApp.Services.Interfaces;

namespace HospitalApp.Services.Implementations
{
    public class MedicationService : IMedicationService
    {
        private readonly IRepository<Medication> _repository;

        public MedicationService(IRepository<Medication> repository)
        {
            _repository = repository;
        }

        public async Task AddMedicationAsync(Medication medication)
        {
            if (medication == null)
                throw new ArgumentNullException(nameof(medication));

            await _repository.AddAsync(medication);
        }

        public async Task<Medication?> GetMedicationByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateMedicationAsync(Medication medication)
        {
            if (medication == null)
                throw new ArgumentNullException(nameof(medication));

            await _repository.UpdateAsync(medication);
        }

        public async Task DeleteMedicationAsync(string id)
        {
            var medication = await _repository.GetByIdAsync(id);
            if (medication != null)
            {
                await _repository.DeleteAsync(medication);
            }
        }
    }
}
