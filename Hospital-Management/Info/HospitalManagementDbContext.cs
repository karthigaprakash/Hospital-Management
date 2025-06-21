using Hospital_Management.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Management.Info
{
    public class HospitalManagementDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Doctor> Doctors { get; set; }

    }

}
