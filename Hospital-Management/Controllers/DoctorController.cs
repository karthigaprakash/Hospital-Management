using Hospital_Management.Model;
using Hospital_Management.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : ControllerBase
    {
        private readonly DoctorRepository repository;

        public DoctorController(DoctorRepository _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDoctors()
        {
            var doctors = await repository.GetAllDoctors();
            return Ok(doctors);
        }

        [HttpPost]
        public async Task<IActionResult> AddDoctor([FromBody] Doctor doctor)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdDoctor = await repository.AddDoctor(doctor);
            return CreatedAtAction(nameof(GetAllDoctors), new { id = createdDoctor.Id }, createdDoctor);
        }
    }
}
