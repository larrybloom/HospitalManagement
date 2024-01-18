using HospitalApp.Data.Repository.Interface;
using HospitalApp.Model.Entities;
using HospitalApp.Services.Interfaces;

namespace HospitalApp.Services.Implementations
{
    public class DischargeService : IDischargeService
    {
        private readonly IRepository<Discharge> _repository;

        public DischargeService(IRepository<Discharge> repository)
        {
            _repository = repository;
        }

        public async Task AddDischargeAsync(Discharge discharge)
        {
            if (discharge == null)
                throw new ArgumentNullException(nameof(discharge));

            await _repository.AddAsync(discharge);
        }

        public async Task<Discharge?> GetDischargeByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateDischargeAsync(Discharge discharge)
        {
            if (discharge == null)
                throw new ArgumentNullException(nameof(discharge));

            await _repository.UpdateAsync(discharge);
        }

        public async Task DeleteDischargeAsync(string id)
        {
            var discharge = await _repository.GetByIdAsync(id);
            if (discharge != null)
            {
                await _repository.DeleteAsync(discharge);
            }
        }
    }
}
