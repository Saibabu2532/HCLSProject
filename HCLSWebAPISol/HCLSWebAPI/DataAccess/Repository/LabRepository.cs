using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataBaseContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class LabRepository : ILabRepository
    {
        public HCLSContextPro LabDb;
        public LabRepository(HCLSContextPro _LabDb)
        {
            LabDb = _LabDb;
        }

        public async Task<int> DeleteLab(int LabId)
        {
             var lb=LabDb.Labs.Find(LabId);
            LabDb.Labs.Remove(lb);
          return await LabDb.SaveChangesAsync();
        }

        public async Task<List<Lab>> GetAllLabs()
        {
          return await LabDb.Labs.ToListAsync();
        }

        public async Task<Lab> GetLabById(int LabId)
        {
           return await LabDb.Labs.FindAsync(LabId);
        }

        public async Task<int> InsertLab(Lab lb)
        {
           await LabDb.Labs.AddAsync(lb);
          return await LabDb.SaveChangesAsync();
        }

        public async Task<int> UpdateLab(Lab lb)
        {
            LabDb.Labs.Update(lb);
          return await LabDb.SaveChangesAsync();
        }
    }
}
