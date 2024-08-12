using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IAdmtypRepository
    {
       Task<List<AdminType>> AllAdminTypes();
        Task<int> InsertAdminType(AdminType Admtyp);
        Task<int> UpdateAdminType(AdminType Admtyp);
        Task<int> DeleteAdminType(int AdminTypeId);
    }
}
