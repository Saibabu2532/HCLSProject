using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IReceptionRepository
    {
        public Task<List<Receptionist>> GetAllReceptionists();
        public Task<Receptionist> GetReceptionByRecpId(int RecpId);
        public Task<int> InsertReception(Receptionist recep);
        public Task<int> UpdateReception(Receptionist recep);
        public Task<int> DeleteReception(int RecpId);
    }
}
