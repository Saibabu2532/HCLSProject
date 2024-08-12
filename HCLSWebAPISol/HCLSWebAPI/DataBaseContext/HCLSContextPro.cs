using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSWebAPI.DataBaseContext
{
    public class HCLSContextPro : DbContext
    {
        public HCLSContextPro(DbContextOptions<HCLSContextPro>options) :base (options) { }
        public DbSet<AdminType> AdminTypes { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
