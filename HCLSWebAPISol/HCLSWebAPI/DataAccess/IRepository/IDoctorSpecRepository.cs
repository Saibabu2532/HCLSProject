using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IDoctorSpecRepository
    {
        public Task<List<DoctorSpecialization>> AllDocSpecialization();
        public Task<DoctorSpecialization> GetDocSpecializationId(int DocSpecId);
        public Task<int> InsertDocSpecialization(DoctorSpecialization DocSpec);
        public Task<int> UpdateDocSpecialization(DoctorSpecialization DocSpec);
        public Task<int> DeleteDocSpecialization(int DocSpecId);
    }
}
