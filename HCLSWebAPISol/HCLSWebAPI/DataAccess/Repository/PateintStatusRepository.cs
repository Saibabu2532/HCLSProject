using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataBaseContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class PateintStatusRepository : IPatientStatusRepository
    {
        public HCLSContextPro Pstatus;
        public PateintStatusRepository(HCLSContextPro _pstatus)
        {
            Pstatus = _pstatus; 
        }

        public async Task<int> DeletePatientStatus(int StatID)
        {
          var Psts=  Pstatus.PatientStatuses.Find(StatID);
            Pstatus.PatientStatuses.Remove(Psts);
          return await  Pstatus.SaveChangesAsync();
        }

        public async Task<List<PatientStatus>> GetAllPatientStatuses()
        {
           return await Pstatus.PatientStatuses.ToListAsync();
        }

        public async Task<PatientStatus> GetPatientStatusById(int StatID)
        {
           return await Pstatus.PatientStatuses.FindAsync(StatID);
        }

        public async Task<int> InsertPatientStatus(PatientStatus patientsts)
        {
           await Pstatus.PatientStatuses.AddAsync(patientsts);
            return await Pstatus.SaveChangesAsync();
        }

        public async Task<int> UpdatePatientStatus(PatientStatus patientsts)
        {
            Pstatus.PatientStatuses.Update(patientsts);
           return await Pstatus.SaveChangesAsync();
        }
    }
}
