using HCLSWebAPI.DataAccess.Repository;
using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IPatientStatusRepository
    {
        public Task<List<PatientStatus>> GetAllPatientStatuses();
        public Task<PatientStatus> GetPatientStatusById(int StatID);
        public Task<int> InsertPatientStatus(PatientStatus patientsts);
        public Task<int> UpdatePatientStatus(PatientStatus patientsts);
        public Task<int> DeletePatientStatus(int StatID);
    }
}
