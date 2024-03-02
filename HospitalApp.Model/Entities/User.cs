using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalApp.Model.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [InverseProperty("Doctor")]
        public List<LaboratoryTest> DoctorLaboratoryTests { get; set; }

        [InverseProperty("User")]
        public List<LaboratoryTest> UserLaboratoryTests { get; set; }

        [InverseProperty("Doctors")]
        public List<Appointment> DoctorAppointments { get; set; }

        [InverseProperty("Users")]
        public List<Appointment> UserAppointments { get; set; }

        public List<Diagnosis> DiagnosisTests { get; set; }
        public List<Discharge> Discharges { get; set; }
        public List<UserHospitals> UserHospitals { get; set; }

        [InverseProperty("Doctor")]
        public List<Medication> DoctorMedications { get; set; }

        [InverseProperty("User")]
        public List<Medication> UserMedications { get; set; }
    }
}
