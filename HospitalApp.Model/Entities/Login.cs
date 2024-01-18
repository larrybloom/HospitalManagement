using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Model.Entities
{
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Jwt { get; set; }
        public IList<string> UserRole { get; set; }
    }
}
