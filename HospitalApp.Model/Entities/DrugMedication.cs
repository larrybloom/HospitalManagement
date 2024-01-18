using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Model.Entities
{
    public class DrugMedication
    {
        public string id { get; set; }
        public string DrugId { get; set; }
        public Drug Drug { get; set; }  
        public string Dosage { get; set; }
        public string MedicationId { get; set; }
        public Medication Medication { get; set; }
    }
}
