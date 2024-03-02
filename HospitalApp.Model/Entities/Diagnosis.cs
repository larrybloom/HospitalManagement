namespace HospitalApp.Model.Entities
{
    public class Diagnosis
    {
        public string id { get; set; }
        public string Details { get; set; }
        public string Remark { get; set; }
        public List<LaboratoryTest> Labs { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string HospitalId { get; set; }
        public Hospital Hospital { get; set; }

    }
}
