using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IDoctorRepository
    {
        public Task<List<Doctor>> AllDoctors();
        public Task<Doctor> GetDoctorByDocId(int DocId);
        public Task<int> DeleteDoctor(int DocId);
        public Task<int> InsertDoctor(Doctor doc);
        public Task<int> UpdateDoctor(Doctor doc);
    }
}
