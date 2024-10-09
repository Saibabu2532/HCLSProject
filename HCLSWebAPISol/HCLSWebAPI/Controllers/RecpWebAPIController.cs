using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Text.RegularExpressions;

namespace HCLSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecpWebAPIController : ControllerBase
    {
        public IReceptionRepository RecpRef;
        public RecpWebAPIController(IReceptionRepository recpRef)
        {
            RecpRef = recpRef;
        }

        [HttpGet]
        [Route("GetAllReceptionists")]

        public async Task<IActionResult> GetAllReceptionists()
        {
            try
            {
                var RecList = await RecpRef.GetAllReceptionists();
                if (RecList.Count > 0)
                {
                    return Ok(RecList);
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
        [Route("GetReceptionByRecpId")]

        public async Task<IActionResult> GetReceptionByRecpId(int RecpId)
        {
            try
            {
                var recep = await RecpRef.GetReceptionByRecpId(RecpId);
                if (recep != null)
                {
                    return Ok(recep);
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
        [Route("InsertReception")]

        public async Task<IActionResult> InsertReception([FromBody] Receptionist recep)
        {
            try
            {
                var count = await RecpRef.InsertReception(recep);
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
        [Route("UpdateReception")]
        public async Task<IActionResult> UpdateReception([FromBody] Receptionist recep)
        {
            try
            {
                var count = await RecpRef.UpdateReception(recep);
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
        [Route("DeleteReception")]
        public async Task<IActionResult> DeleteReception(int RecpId)
        {
            try
            {
                var count = await RecpRef.DeleteReception(RecpId);
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
