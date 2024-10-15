using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataBaseContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class PatientRepository : IPatientRepository
    {
        public HCLSContextPro Ptnst;
        public PatientRepository(HCLSContextPro _Ptnst)
        {
           Ptnst =_Ptnst;
        }

        public async Task<List<Patient>> AllPatients()
        {
          return await  Ptnst.Patients.ToListAsync();
        }

        public async Task<int> DeletePatient(int PatientID)
        {
            var Pnt = Ptnst.Patients.Find(PatientID);
            Ptnst.Patients.Remove(Pnt);
           return await Ptnst.SaveChangesAsync();   
        }

        public async Task<List<Patient>> DocSpecIdByPatient(int DocSpecId)
        {
          return await  Ptnst.Patients.Where(x=>x.DocSpecId == DocSpecId).ToListAsync();
        }

        public async Task<List<Patient>> DoctorIdByPatient(int DocId)
        {
          return await  Ptnst.Patients.Where(x=>x.DocId == DocId).ToListAsync();
        }

        public async Task<Patient> GetLoginByEmailAndPassword(string Email, string Password)
        {
           return await  Ptnst.Patients.Where(x=>x.Email==Email && x.Password==Password).SingleOrDefaultAsync();
        }

        public async Task<List<Patient>> HelperIdByPatient(int HelpId)
        {
          return await  Ptnst.Patients.Where(x=>x.HelpId == HelpId).ToListAsync();
        }

        public async Task<int> InsertPatient(Patient Patnt)
        {
            await Ptnst.Patients.AddAsync(Patnt);
           return await Ptnst.SaveChangesAsync();
        }

        public async Task<List<Patient>> LabIdByPatient(int LabId)
        {
            return await Ptnst.Patients.Where(x=>x.LabId == LabId).ToListAsync();
        }

        public async Task<List<Patient>> PatienStsIdByPatient(int StatID)
        {
           return await Ptnst.Patients.Where(x=>x.StatId == StatID).ToListAsync();
        }

        public async Task<Patient> PatientById(int PatientID)
        {
           return await Ptnst.Patients.FindAsync(PatientID);
        }

        public async Task<List<Patient>> ReceptionIdByPatient(int RecpId)
        {
            return await Ptnst.Patients.Where(x=>x.RecpId == RecpId).ToListAsync(); 
        }

        public async Task<int> UpdatePatient(Patient Patnt)
        {
            Ptnst.Patients.Update(Patnt);
           return await  Ptnst.SaveChangesAsync();
        }
    }
}
