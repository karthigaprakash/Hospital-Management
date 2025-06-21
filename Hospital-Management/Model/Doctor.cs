using System.ComponentModel.DataAnnotations;

namespace Hospital_Management.Model
{
    public class Doctor
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Specialization { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public int Experience { get; set; }

        public string? AvailableDays { get; set; } 
    }
}
