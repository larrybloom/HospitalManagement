using System.Threading.Tasks;
using HospitalApp.Data.Repository.Interface;
using HospitalApp.Model.Entities;
using HospitalApp.Services.Interfaces;

namespace HospitalApp.Services.Implementations
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IRepository<Appointment> _repository;

        public AppointmentService(IRepository<Appointment> repository)
        {
            _repository = repository;
        }

        public async Task AddAppointmentAsync(Appointment appointment)
        {
            await _repository.AddAsync(appointment);
        }

        public async Task<Appointment?> GetAppointmentByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateAppointmentAsync(Appointment appointment)
        {
            await _repository.UpdateAsync(appointment);
        }

        public async Task DeleteAppointmentAsync(string id)
        {
            var appointment = await _repository.GetByIdAsync(id);
            if (appointment != null)
            {
                await _repository.DeleteAsync(appointment);
            }
        }
    }
}
