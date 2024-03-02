namespace HospitalApp.Model.Entities
{
    public class Hospital
    {
        public string id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public List<Drug> Drugs { get; set; }
        public List<User> Users { get; set; }
        public List<Discharge> Discharges { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Diagnosis> Diagnosis { get; set; }
        public List<Medication> Medications { get; set; }
        public List<UserHospitals> Hospitals { get; set; }
        public List<LaboratoryTest> LaboratoryTests { get; set; }


    }
}
