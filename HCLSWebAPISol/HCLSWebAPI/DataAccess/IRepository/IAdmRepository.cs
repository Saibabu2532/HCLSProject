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
        Task<int> UpadteAdmin(Admin Adm);
       Task<int> DeleteAdmin(int AdminTypeId);
        Task<Admin> LoginByEmailAndPassword(string Email, string Password);
        Task<Admin> GetAdminByAdminEmail(string EMail);
    }
}
