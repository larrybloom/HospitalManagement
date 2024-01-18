using HospitalApp.Model.DTOs;

namespace HospitalApp.Services.Interfaces
{
    public interface IEmailServices
    {
        void SendEmail(Message message);
    }
}
