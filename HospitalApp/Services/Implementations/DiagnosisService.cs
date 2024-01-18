using HospitalApp.Data.Repository.Interface;
using HospitalApp.Model.Entities;
using HospitalApp.Services.Interfaces;

namespace HospitalApp.Services.Implementations
{
    public class DiagnosisService : IDiagnosisService
    {
        private readonly IRepository<Diagnosis> _repository;

        public DiagnosisService(IRepository<Diagnosis> repository)
        {
            _repository = repository;
        }

        public async Task AddDiagnosisAsync(Diagnosis diagnosis)
        {
            if (diagnosis == null)
                throw new ArgumentNullException(nameof(diagnosis));

            await _repository.AddAsync(diagnosis);
        }

        public async Task<Diagnosis?> GetDiagnosisByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateDiagnosisAsync(Diagnosis diagnosis)
        {
            if (diagnosis == null)
                throw new ArgumentNullException(nameof(diagnosis));

            await _repository.UpdateAsync(diagnosis);
        }

        public async Task DeleteDiagnosisAsync(string id)
        {
            var diagnosis = await _repository.GetByIdAsync(id);
            if (diagnosis != null)
            {
                await _repository.DeleteAsync(diagnosis);
            }
        }
    }
}
