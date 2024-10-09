using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataBaseContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class DoctorSpecRepository : IDoctorSpecRepository
    {
        public HCLSContextPro DcrtspcDb;
        public DoctorSpecRepository(HCLSContextPro _dcrtspcDb)
        {
            DcrtspcDb = _dcrtspcDb;
        }

        public async Task<List<DoctorSpecialization>> AllDocSpecialization()
        {
          return await DcrtspcDb.DoctorSpecializations.ToListAsync();
        }

        public async Task<int> DeleteDocSpecialization(int DocSpecId)
        {
            var DocSpec=DcrtspcDb.DoctorSpecializations.Find(DocSpecId);
            DcrtspcDb.DoctorSpecializations.Remove(DocSpec);
          return await DcrtspcDb.SaveChangesAsync();
        }

        public async Task<DoctorSpecialization> GetDocSpecializationId(int DocSpecId)
        {
          return  await DcrtspcDb.DoctorSpecializations.FindAsync(DocSpecId);
        }

        public async Task<int> InsertDocSpecialization(DoctorSpecialization DocSpec)
        {
           await DcrtspcDb.DoctorSpecializations.AddAsync(DocSpec);
          return await DcrtspcDb.SaveChangesAsync();
        }

        public async Task<int> UpdateDocSpecialization(DoctorSpecialization DocSpec)
        {
            DcrtspcDb.DoctorSpecializations.Update(DocSpec);
          return await DcrtspcDb.SaveChangesAsync();
        }
    }
}
