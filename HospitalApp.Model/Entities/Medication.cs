namespace HospitalApp.Model.Entities
{
    public class Medication
    {
        public string Id { get; set; }
        public string Summary { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public List<DrugMedication> DrugMedications { get; set; }
        public DateTime StartDate { get; set; }
        public string DoctorId { get; set; }
        public User Doctor { get; set; }
        public DateTime EndDate { get; set; }
        public string DiagnosisId { get; set; }
        public Diagnosis Diagnosis { get; set; }
        public string Status { get; set; }
        public string HospitalId { get; set; }
        public Hospital Hospital { get; set; }
    }
}
