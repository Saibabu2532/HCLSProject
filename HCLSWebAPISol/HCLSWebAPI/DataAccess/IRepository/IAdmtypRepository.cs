using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IAdmtypRepository
    {
        public Task<List<AdminType>> AllAdminTypes();
        public Task<AdminType> GetAdminTypeID(int AdminTypeId);
        public Task<int> InsertAdminType(AdminType Admtyp);
        public Task<int> UpdateAdminType(AdminType Admtyp);
        public Task<int> DeleteAdminType(int AdminTypeId);
    }
}
