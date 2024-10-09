using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IDeptRepository
    {
       public Task<List<Department>> AllDepartments();
        public Task<Department> GetDepartmentNo(int DeptNo);
        public Task<int> InsertDepartment(Department Dept);
        public Task<int> UpdateDepartment(Department Dep);
        public Task<int> DeleteDepartment(int DeptNo);
    }
}
