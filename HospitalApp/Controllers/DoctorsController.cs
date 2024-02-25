using HospitalApp.Data.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorsController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }


        [HttpGet("search")]
        public async Task<IActionResult> SearchDoctors([FromQuery] string searchTerm)
        {
            try
            {
                var doctors = await _doctorRepository.SearchDoctorsAsync(searchTerm);
                return Ok(doctors);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, "An unexpected error occurred.");
            }
        }
    }
}
