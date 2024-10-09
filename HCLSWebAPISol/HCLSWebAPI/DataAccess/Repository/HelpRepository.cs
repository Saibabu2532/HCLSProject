using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataBaseContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class HelpRepository : IHelpRepository
    {
        public HCLSContextPro HelpDb;
        public HelpRepository(HCLSContextPro _HelpDb)
        {
            HelpDb = _HelpDb;
        }

        public async Task<List<Helper>> AllHelpers()
        {
          return await HelpDb.Helpers.ToListAsync();
        }

        public async Task<int> DeleteHelper(int HelpId)
        {
            var help=HelpDb.Helpers.Find(HelpId);
            HelpDb.Helpers.Remove(help);
          return await HelpDb.SaveChangesAsync();
        }

        public async Task<Helper> GetHelperByHelId(int HelpId)
        {
          return await HelpDb.Helpers.FindAsync(HelpId);
        }

        public async Task<int> InsertHelper(Helper help)
        {
            await HelpDb.Helpers.AddAsync(help);
          return await HelpDb.SaveChangesAsync();
        }

        public async Task<int> UpdateHelper(Helper help)
        {
             HelpDb.Helpers.Update(help);
          return await HelpDb.SaveChangesAsync();
        }
    }
}
