using HospitalApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Data.Repository.Interface
{
    public interface IDoctorRepository
    {
        Task<IEnumerable<Doctor>> SearchDoctorsAsync(string searchTerm);
    }
}
