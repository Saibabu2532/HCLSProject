﻿using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataBaseContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class AdmRepository : IAdmRepository
    {
        public HCLSContextPro AdmDb;
        public AdmRepository(HCLSContextPro _AdmDb)
        {
            AdmDb = _AdmDb;
        }

        public async Task<int> AdminRegistrations(Admin Adm)
        {
            await AdmDb.Admins.AddAsync(Adm);
          return await AdmDb.SaveChangesAsync();
        }
        public async Task<int> DeleteAdmin(int AdminTypeId)
        {
            var adm = AdmDb.Admins.Find(AdminTypeId);
            AdmDb.Admins.Remove(adm);
          return await AdmDb.SaveChangesAsync();
        }

        public async Task<int> UpadteAdmin(Admin Adm)
        {
             AdmDb.Admins.Update(Adm);
          return await AdmDb.SaveChangesAsync();
        }

       public async Task<List<Admin>> AllOperationalAdmins()
        {
             return await AdmDb.Admins.ToListAsync();
        }

        public async Task<Admin> LoginByEmailAndPassword(string Email, string Password)
        {
          return await AdmDb.Admins.Where(x=>x.Email==Email && x.Password==Password).SingleOrDefaultAsync();
        }

        public async Task<Admin> GetAdminByAdminEmail(string EMail)
        {
          return await AdmDb.Admins.Where(x=>x.Email==EMail).SingleOrDefaultAsync();
        }

        public async Task<Admin> GetAdminByAdminId(int AdminId)
        {
          return await  AdmDb.Admins.FindAsync(AdminId);
        }

        public async Task<List<Admin>> GetAdminTypeIdByAdmin(int AdminTypeId)
        {
         return  await AdmDb.Admins.Where(x=>x.AdminTypeId==AdminTypeId).ToListAsync();
        }
    }
}
