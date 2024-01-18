using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Model.Entities
{
    public class ConfirmEmailToken
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int Token { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
