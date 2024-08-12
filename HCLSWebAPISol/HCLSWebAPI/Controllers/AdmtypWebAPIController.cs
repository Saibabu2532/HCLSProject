using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HCLSWebAPI.DataAccess;
using System.Collections.Generic;
using HCLSWebAPI.Models;
using System.Threading.Tasks;
using System;
using HCLSWebAPI.DataAccess.IRepository;

namespace HCLSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdmtypWebAPIController : ControllerBase
    {
        public IAdmtypRepository IAdmtypRef;
        public AdmtypWebAPIController(IAdmtypRepository _admtypRef)
        {
            IAdmtypRef = _admtypRef;
        }


        [HttpGet]
        [Route("AllAdminTypes")]
        public async Task<IActionResult> AllAdminTypes()
        {
            try
            {
                var ListAdmtyp = await IAdmtypRef.AllAdminTypes();
                if (ListAdmtyp.Count > 0)
                {
                    return Ok(ListAdmtyp);
                }
                else
                {
                    return BadRequest("Records are Not Available in the Database.....!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Somethig went Wrong ..!\n" + "Issue : " + ex.Message + ".\nwe will solve this issue soon ...1");
            }

        }

        [HttpPost]
        [Route("InsertAdminType")]
        public async Task<IActionResult> InsertAdminType([FromBody] AdminType Admtyp)
        {
            try
            {
                var count = await IAdmtypRef.InsertAdminType(Admtyp);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return BadRequest("Record is Not Inserted.....!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Somethig went Wrong ..!\n" + "Issue : " + ex.Message + ".\nwe will solve this issue soon ...1");
            }

        }

        [HttpPut]
        [Route("UpdateAdminType")]
        public async Task<IActionResult> UpdateAdminType([FromBody] AdminType Admtyp)
        {
            try
            {
                var count = await IAdmtypRef.UpdateAdminType(Admtyp);
                if (count > 0)
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
        [Route("DeleteAdminType")]
        public async Task<IActionResult> DeleteAdminType(int AdminTypeId)
        {
            try
            {
                var count = await IAdmtypRef.DeleteAdminType(AdminTypeId);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return BadRequest("Records are Not Delete in Database.....!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Somethig went Wrong ..!\n" + "Issue : " + ex.Message + ".\nwe will solve this issue soon ...1");
            }

        }
    }
}
