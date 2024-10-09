using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IAdmRepository 
    {
         Task<List<Admin>> AllOperationalAdmins();
        Task<int> AdminRegistrations(Admin Adm);
        public Task<List<Admin>> GetAdminTypeIdByAdmin(int AdminTypeId);
        Task<int> UpadteAdmin(Admin Adm);
       Task<int> DeleteAdmin(int AdminTypeId);
        Task<Admin> LoginByEmailAndPassword(string Email, string Password);
        Task<Admin> GetAdminByAdminEmail(string EMail);
        Task<Admin> GetAdminByAdminId(int AdminId);
    }
}
