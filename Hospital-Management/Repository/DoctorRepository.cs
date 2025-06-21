using Hospital_Management.Info;
using Hospital_Management.Model;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Management.Repository
{
    public class DoctorRepository
    {
        private readonly HospitalManagementDbContext context;

        public DoctorRepository (HospitalManagementDbContext _context)
        {
            context = _context;
        }

        public async Task<List<Doctor>> GetAllDoctors()
        {
            return await context.Doctors
                                .AsNoTracking()
                                .ToListAsync();
        }

        public async Task<Doctor> AddDoctor(Doctor doctor)
        {
            await context.Doctors.AddAsync(doctor);
            await context.SaveChangesAsync();

            return doctor;
        }
    }
}
