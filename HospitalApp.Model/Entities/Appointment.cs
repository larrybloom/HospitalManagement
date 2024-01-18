namespace HospitalApp.Model.Entities
{
    public class Appointment
    {
        public string id { get; set; }
        public string UsersId { get; set; }
        public User Users { get; set; }
        public string DoctorsId { get; set; }
        public User Doctors { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; }
        public string HospitalId { get; set; }
        public Hospital Hospital { get; set; }
    }
}