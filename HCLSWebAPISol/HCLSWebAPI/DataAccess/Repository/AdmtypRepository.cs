using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataBaseContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class AdmtypRepository : IAdmtypRepository
    {
        public HCLSContextPro AdmtypDb;
        public AdmtypRepository(HCLSContextPro _AdmtypDb)
        {
            AdmtypDb = _AdmtypDb;
        }

        public async Task<List<AdminType>> AllAdminTypes()
        {
          return await AdmtypDb.AdminTypes.ToListAsync();
        }

        public async Task<int> DeleteAdminType(int AdminTypeId)
        {
            var Admtyp = AdmtypDb.AdminTypes.Find(AdminTypeId);
            AdmtypDb.AdminTypes.Remove(Admtyp);
            return await AdmtypDb.SaveChangesAsync();
        }

        public async Task<AdminType> GetAdminTypeID(int AdminTypeId)
        {
          return await AdmtypDb.AdminTypes.FindAsync(AdminTypeId);
        }

        public async Task<int> InsertAdminType(AdminType Admtyp)
        {
           await AdmtypDb.AdminTypes.AddAsync(Admtyp);
           return await AdmtypDb.SaveChangesAsync();

        }

        public async Task<int> UpdateAdminType(AdminType Admtyp)
        {
            AdmtypDb.AdminTypes.Update(Admtyp);
          return await AdmtypDb.SaveChangesAsync();
        }

        
    }
}
