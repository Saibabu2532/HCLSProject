using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using HCLSWebAPI.DataAccess;
using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.Models;

namespace HCLSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdmWebAPIController : ControllerBase
    {
        public IAdmRepository IAdmRef;
        public AdmWebAPIController(IAdmRepository _admRef)
        {
            IAdmRef = _admRef;
        }

        [HttpPost]
        [Route("AdminRegistrations")]
        public async Task<IActionResult> AdminRegistrations([FromBody] Admin Adm)
        {
            try
            {
                var count = await IAdmRef.AdminRegistrations(Adm);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return BadRequest("Records are Not Register.....!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Somethig went Wrong ..!\n" + "Issue : " + ex.Message + ".\nwe will solve this issue soon ...1");
            }

        }

        [HttpGet]
        [Route("AllOperationalAdmins")]
        public async Task<IActionResult> AllOperationalAdmins()
        {
            try
            {
                var ListAdm = await IAdmRef.AllOperationalAdmins();
                if(ListAdm.Count > 0)
                {
                    return Ok(ListAdm);
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


        [HttpGet]
        [Route("LoginByEmailAndPassword")]
        public async Task<IActionResult> LoginByEmailAndPassword(string Email , string Password)
        {
            try
            {
                var Adm = await IAdmRef.GetLoginByEmailAndPassword(Email,Password);
                if (Adm != null)
                {
                    return Ok(Adm);
                }
                else
                {
                    return BadRequest("Record is Not Available in the Database.....!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Somethig went Wrong ..!\n" + "Issue : " + ex.Message + ".\nwe will solve this issue soon ...1");
            }

        }

        [HttpGet]
        [Route("AdminByAdminEmail")]
        public async Task<IActionResult> AdminByAdminEmail(string Email)
        {
            try
            {
                var Adm = await IAdmRef.GetAdminByAdminEmail(Email);
                if (Adm != null)
                {
                    return Ok(Adm);
                }
                else
                {
                    return BadRequest("Record is Not Available in the Database.....!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Somethig went Wrong ..!\n" + "Issue : " + ex.Message + ".\nwe will solve this issue soon ...1");
            }

        }


        [HttpPut]
        [Route("UpadteAdmin")]
        public async Task<IActionResult> UpadteAdmin([FromBody] Admin Adm)
        {
            try
            {
                var count = await IAdmRef.UpadteAdmin(Adm);
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
        [Route("DeleteAdmin")]
        public async Task<IActionResult> DeleteAdmin(int AdminTypeId)
        {
            try
            {
                var count = await IAdmRef.DeleteAdmin(AdminTypeId);
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
