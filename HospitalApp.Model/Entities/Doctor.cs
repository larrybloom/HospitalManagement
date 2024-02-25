using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Model.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public bool IsAvailable { get; set; }
        public string HospitalAddress { get; set; }
        public decimal ConsultationFee { get; set; }
    }
}