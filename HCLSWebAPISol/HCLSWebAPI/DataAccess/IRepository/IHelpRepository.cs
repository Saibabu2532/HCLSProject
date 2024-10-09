using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IHelpRepository
    {
        public Task<List<Helper>> AllHelpers();
        public Task<Helper> GetHelperByHelId(int HelpId);
        public Task<int> InsertHelper(Helper help);
        public Task<int> UpdateHelper(Helper help);
        public Task<int> DeleteHelper(int HelpId);
    }
}
