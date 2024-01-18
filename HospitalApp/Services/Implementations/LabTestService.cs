using HospitalApp.Data.Repository.Interface;
using HospitalApp.Model.Entities;
using HospitalApp.Services.Interfaces;

namespace HospitalApp.Services.Implementations
{
    public class LabTestService : ILabTestService
    {
        private readonly IRepository<LaboratoryTest> _repository;

        public LabTestService(IRepository<LaboratoryTest> repository)
        {
            _repository = repository;
        }

        public async Task AddLabTestAsync(LaboratoryTest labTest)
        {
            if (labTest == null)
                throw new ArgumentNullException(nameof(labTest));

            await _repository.AddAsync(labTest);
        }

        public async Task<LaboratoryTest?> GetLabTestByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateLabTestAsync(LaboratoryTest labTest)
        {
            if (labTest == null)
                throw new ArgumentNullException(nameof(labTest));

            await _repository.UpdateAsync(labTest);
        }

        public async Task DeleteLabTestAsync(string id)
        {
            var labTest = await _repository.GetByIdAsync(id);
            if (labTest != null)
            {
                await _repository.DeleteAsync(labTest);
            }
        }
    }
}
