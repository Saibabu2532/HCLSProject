using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IPatientRepository
    {
        public Task<List<Patient>> AllPatients();
        public Task<Patient> PatientById(int PatientID);
        public Task<int> InsertPatient(Patient Patnt);
        public Task<int> UpdatePatient(Patient Patnt);  
        public Task<int> DeletePatient(int PatientID);
        public Task<Patient> GetLoginByEmailAndPassword(string Email, string Password);
        public Task<List<Patient>> HelperIdByPatient(int HelpId); 
        public Task<List<Patient>> LabIdByPatient(int LabId);
        public Task<List<Patient>> ReceptionIdByPatient(int RecpId);
        public Task<List<Patient>> DoctorIdByPatient(int DocId);
        public Task<List<Patient>> DocSpecIdByPatient(int DocSpecId);
        public Task<List<Patient>> PatienStsIdByPatient(int StatID);
    }
}
