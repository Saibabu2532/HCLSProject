using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface ILabRepository
    {
        public Task<List<Lab>> GetAllLabs();
        public Task<Lab> GetLabById(int LabId);
        public Task<int> InsertLab(Lab lb);
        public Task<int> UpdateLab(Lab lb);
        public Task<int> DeleteLab(int LabId);
    }
}
