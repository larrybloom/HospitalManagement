using HospitalApp.Data.Context;
using HospitalApp.Data.Repository.Interface;
using HospitalApp.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Data.Repository.Implementations
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DataContext _context;

        public DoctorRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Doctor>> SearchDoctorsAsync(string searchTerm)
        {
            return await _context.Doctors
                .Where(d => d.Name.Contains(searchTerm)) 
                .ToListAsync();
        }
    }
}
