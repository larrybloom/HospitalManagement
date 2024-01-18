using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Model.Entities
{
    public class UserHospitals
    {
        public string id { get; set; }
        public string HospitalId { get; set; }
        public Hospital Hospital { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

    }
}
