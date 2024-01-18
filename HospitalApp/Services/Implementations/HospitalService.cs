using HospitalApp.Data.Repository.Interface;
using HospitalApp.Model.Entities;
using HospitalApp.Services.Interfaces;

namespace HospitalApp.Services.Implementations
{
    public class HospitalService : IHospitalService
    {
        private readonly IRepository<Hospital> _repository;

        public HospitalService(IRepository<Hospital> repository)
        {
            _repository = repository;
        }

        public async Task AddHospitalAsync(Hospital hospital)
        {
            if (hospital == null)
                throw new ArgumentNullException(nameof(hospital));

            await _repository.AddAsync(hospital);
        }

        public async Task<Hospital?> GetHospitalByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id.ToString());
        }

        public async Task UpdateHospitalAsync(Hospital hospital)
        {
            if (hospital == null)
                throw new ArgumentNullException(nameof(hospital));

            await _repository.UpdateAsync(hospital);
        }

        public async Task DeleteHospitalAsync(int id)
        {
            var hospital = await _repository.GetByIdAsync(id.ToString());
            if (hospital != null)
            {
                await _repository.DeleteAsync(hospital);
            }
        }
    }
}
