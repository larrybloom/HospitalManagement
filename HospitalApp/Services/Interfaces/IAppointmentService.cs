using System.Threading.Tasks;
using HospitalApp.Model.Entities;

namespace HospitalApp.Services.Interfaces
{
    public interface IAppointmentService
    {
        Task AddAppointmentAsync(Appointment appointment);
        Task<Appointment?> GetAppointmentByIdAsync(string id);
        Task UpdateAppointmentAsync(Appointment appointment);
        Task DeleteAppointmentAsync(string id);
    }
}
