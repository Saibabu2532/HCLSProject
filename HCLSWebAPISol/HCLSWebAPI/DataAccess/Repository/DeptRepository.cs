using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataBaseContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.Repository
{
    public class DeptRepository:IDeptRepository
    {
        public HCLSContextPro DeptDb;
        public DeptRepository(HCLSContextPro _DeptDb)
        {
            DeptDb = _DeptDb;
        }

        public async Task<List<Department>> AllDepartments()
        {
          return await DeptDb.Departments.ToListAsync();
        }

        public async Task<int> DeleteDepartment(int DeptNo)
        {
            var Dept = DeptDb.Departments.Find(DeptNo);
            DeptDb.Departments.Remove(Dept);
          return await DeptDb.SaveChangesAsync();
        }

        public async Task<Department> GetDepartmentNo(int DeptNo)
        {
          return await DeptDb.Departments.FindAsync(DeptNo);
        }

        public async Task<int> InsertDepartment(Department Dept)
        {
            await DeptDb.Departments.AddAsync(Dept);
          return await DeptDb.SaveChangesAsync();
        }

        public async Task<int> UpdateDepartment(Department Dep)
        {
            DeptDb.Departments.Update(Dep);
          return await DeptDb.SaveChangesAsync();
        }

        
    }
}
