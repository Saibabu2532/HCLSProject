using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HCLSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptWebAPIController : ControllerBase
    {
        public IDeptRepository IDeptRef;
        public DeptWebAPIController(IDeptRepository _DeptRef)
        {
            IDeptRef= _DeptRef;
        }

        [HttpGet]
        [Route("AllDepartments")]

        public async Task<IActionResult> AllDepartments()
        {
            try
            {
                var DeptList = await IDeptRef.AllDepartments();
                if(DeptList.Count>0)
                {
                    return Ok(DeptList);
                }
                else
                {
                    return BadRequest("Records are Not Available in the Database.....!");
                }

            }
            catch(Exception  ex) 
            {
                return BadRequest("Somethig went Wrong ..!\n" + "Issue : " + ex.Message + ".\nwe will solve this issue soon ...1");
            }
        }

        [HttpGet]
        [Route("GetDepartmentNo")]

        public async Task<IActionResult> GetDepartmentNo(int DeptNo)
        {
            try
            {
                var Dept = await IDeptRef.GetDepartmentNo(DeptNo);
                if (Dept != null)
                {
                    return Ok(Dept);
                }
                else
                {
                    return BadRequest("Records are Not Available in the Database.....!");

                }
            }
            catch(Exception ex)
            {
                return BadRequest("Somethig went Wrong ..!\n" + "Issue : " + ex.Message + ".\nwe will solve this issue soon ...1");
            }
        }

        [HttpPost]
        [Route("InsertDepartment")]

        public async Task<IActionResult> InsertDepartment([FromBody] Department dept)
        {
            try
            {
                var count = await IDeptRef.InsertDepartment(dept);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return BadRequest("Record is Not Inserted.....!");
                }

            }
            catch(Exception ex)
            {
                return BadRequest("Somethig went Wrong ..!\n" + "Issue : " + ex.Message + ".\nwe will solve this issue soon ...1");
            }
        }

        [HttpPut]
        [Route("UpdateDepartment")]
        public async Task<IActionResult> UpdateDepartment([FromBody] Department dept)
        {
            try
            {
                var count = await IDeptRef.UpdateDepartment(dept);
                if(count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return BadRequest("Records are Not Update in Database.....!");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Somethig went Wrong ..!\n" + "Issue : " + ex.Message + ".\nwe will solve this issue soon ...1");

            }
        }
        [HttpDelete]
        [Route("DeleteDepartment")]
        public async Task<IActionResult> DeleteDepartment(int DeptNo)
        {
            try
            {
                var count = await IDeptRef.DeleteDepartment(DeptNo);
                if(count>0)
                {
                    return Ok(count);
                }
                else
                {
                    return BadRequest("Records are Not Delete in Database.....!");
                }

            }
            catch(Exception ex)
            {
                return BadRequest("Somethig went Wrong ..!\n" + "Issue : " + ex.Message + ".\nwe will solve this issue soon ...1");
            }
        }
    }
}
