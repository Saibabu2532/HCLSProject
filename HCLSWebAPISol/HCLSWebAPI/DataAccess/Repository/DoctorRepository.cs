using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataBaseContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        public HCLSContextPro DctrDb;
        public DoctorRepository(HCLSContextPro _dctrDb)
        {
            DctrDb = _dctrDb;
        }

        public async Task<List<Doctor>> AllDoctors()
        {
          return await DctrDb.Doctors.ToListAsync();
        }

        public async Task<int> DeleteDoctor(int DocId)
        {
            var doc=DctrDb.Doctors.Find(DocId);
            DctrDb.Doctors.Remove(doc);
          return await DctrDb.SaveChangesAsync();
        }

        public async Task<Doctor> GetDoctorByDocId(int DocId)
        {
           return await DctrDb.Doctors.FindAsync(DocId);
        }

        public async Task<int> InsertDoctor(Doctor doc)
        {
           await DctrDb.Doctors.AddAsync(doc);
          return await DctrDb.SaveChangesAsync();
        }

        public async Task<int> UpdateDoctor(Doctor doc)
        {
             DctrDb.Doctors.Update(doc);
            return await DctrDb.SaveChangesAsync();
        }
    }
}
