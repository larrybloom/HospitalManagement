using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Model.Entities
{
    public class Drug
    {
        public string id { get; set; }
        public string CompanyName { get; set; }
        public string DrugName { get; set; }
        public string Description { get; set; }
        public List<DrugMedication> DrugsMedications { get; set; }
        public string HospitalId { get; set; }
        public Hospital Hospital { get; set; }

    }
}
