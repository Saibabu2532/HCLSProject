using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace HCLSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabWebAPIController : ControllerBase
    {
        public ILabRepository LabRef;
        public LabWebAPIController(ILabRepository labRef)
        { 
            LabRef = labRef;
        }

        [HttpGet]
        [Route("GetAllLabs")]

        public async Task<IActionResult> GetAllLabs()
        {
            try
            {
                var LabList = await LabRef.GetAllLabs();
                if (LabList.Count > 0)
                {
                    return Ok(LabList);
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
        [Route("GetLabById")]

        public async Task<IActionResult> GetLabById(int LabId)
        {
            try
            {
                var lb = await LabRef.GetLabById(LabId);
                if (lb != null)
                {
                    return Ok(lb);
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
        [Route("InsertLab")]

        public async Task<IActionResult> InsertLab([FromBody] Lab lb)
        {
            try
            {
                var count = await LabRef.InsertLab(lb);
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
        [Route("UpdateLab")]
        public async Task<IActionResult> UpdateLab([FromBody] Lab lb)
        {
            try
            {
                var count = await LabRef.UpdateLab(lb);
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
        [Route("DeleteLab")]
        public async Task<IActionResult> DeleteLab(int LabId)
        {
            try
            {
                var count = await LabRef.DeleteLab(LabId);
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
