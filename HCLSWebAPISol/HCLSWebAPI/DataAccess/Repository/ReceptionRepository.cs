using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataBaseContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class ReceptionRepository:IReceptionRepository
    {
        public HCLSContextPro RecDb;
        public ReceptionRepository(HCLSContextPro _RecDb)
        { 
            RecDb = _RecDb;
        }

        public async Task<int> DeleteReception(int RecepId)
        {
            var recep = RecDb.Receptionists.Find(RecepId);
            RecDb.Receptionists.Remove(recep);
          return await RecDb.SaveChangesAsync();
        }

        public async Task<List<Receptionist>> GetAllReceptionists()
        {
          return await RecDb.Receptionists.ToListAsync();
        }

        public async Task<Receptionist> GetReceptionByRecpId(int RecpId)
        {
           return await RecDb.Receptionists.FindAsync(RecpId);
        }

        public async Task<int> InsertReception(Receptionist recep)
        {
           await RecDb.Receptionists.AddAsync(recep);
          return await RecDb.SaveChangesAsync();
        }

        public async Task<int> UpdateReception(Receptionist recep)
        {
            RecDb.Receptionists.Update(recep);
          return await RecDb.SaveChangesAsync();
        }
    }
}
