using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Model.Entities
{
    public class LaboratoryTest
    {

        public Diagnosis Diagnosis { get; set; }
        public string DiagnosisId { get; set; }

        public  string id { get; set; }
        public string Test { get; set; }
        public DateTime Date { get; set; }
        public string Result { get; set; }
        public string HospitalId { get; set; }
        public Hospital Hospital { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string DoctorId { get; set; }
        public User Doctor { get; set; }
        public string TestStatus { get; set; }
        public DateTime TestDate { get; set; }
    }
}
