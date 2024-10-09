using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSWebAPI.DataBaseContext
{
    public class HCLSContextPro : DbContext
    {
        public HCLSContextPro(DbContextOptions<HCLSContextPro>options) :base (options) { }
        public DbSet<AdminType> AdminTypes { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Receptionist> Receptionists { get; set; }
        public DbSet<Helper> Helpers { get; set; }
        public DbSet<Lab> Labs { get; set; }
        public DbSet<DoctorSpecialization> DoctorSpecializations { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

    }
}
