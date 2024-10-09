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
    public class DctrSpecWebAPIController : ControllerBase
    {
        public IDoctorSpecRepository DoctspeRef;
        public DctrSpecWebAPIController(IDoctorSpecRepository _DoctspeRef)
        {
            DoctspeRef = _DoctspeRef;
        }

        [HttpGet]
        [Route("AllDocSpecialization")]

        public async Task<IActionResult> AllDocSpecialization()
        {
            try
            {
                var DocSpecList = await DoctspeRef.AllDocSpecialization();
                if (DocSpecList.Count > 0)
                {
                    return Ok(DocSpecList);
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
        [Route("GetDocSpecializationId")]

        public async Task<IActionResult> GetDocSpecializationId(int DocSpecId)
        {
            try
            {
                var DocSpec = await DoctspeRef.GetDocSpecializationId(DocSpecId);
                if (DocSpec != null)
                {
                    return Ok(DocSpec);
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
        [Route("InsertDocSpecialization")]

        public async Task<IActionResult> InsertDocSpecialization([FromBody] DoctorSpecialization DocSpec)
        {
            try
            {
                var count = await DoctspeRef.InsertDocSpecialization(DocSpec);
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
        [Route("UpdateDocSpecialization")]
        public async Task<IActionResult> UpdateDocSpecialization([FromBody] DoctorSpecialization DocSpec)
        {
            try
            {
                var count = await DoctspeRef.UpdateDocSpecialization(DocSpec);
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
        [Route("DeleteDocSpecialization")]
        public async Task<IActionResult> DeleteDocSpecialization(int DocSpecId)
        {
            try
            {
                var count = await DoctspeRef.DeleteDocSpecialization(DocSpecId);
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
