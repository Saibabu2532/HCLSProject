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
    public class DctrWebAPIController : ControllerBase
    {
        public IDoctorRepository DoctRef;
        public DctrWebAPIController(IDoctorRepository _DoctRef)
        {
            DoctRef = _DoctRef;
        }


        [HttpGet]
        [Route("AllDoctors")]

        public async Task<IActionResult> AllDoctors()
        {
            try
            {
                var DocList = await DoctRef.AllDoctors();
                if (DocList.Count > 0)
                {
                    return Ok(DocList);
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
        [Route("GetDoctorByDocId")]

        public async Task<IActionResult> GetDoctorByDocId(int DocId)
        {
            try
            {
                var doc = await DoctRef.GetDoctorByDocId(DocId);
                if (doc != null)
                {
                    return Ok(doc);
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
        [Route("InsertDoctor")]

        public async Task<IActionResult> InsertDoctor([FromBody] Doctor doc)
        {
            try
            {
                var count = await DoctRef.InsertDoctor(doc);
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
        [Route("UpdateDoctor")]
        public async Task<IActionResult> UpdateDoctor([FromBody] Doctor doc)
        {
            try
            {
                var count = await DoctRef.UpdateDoctor(doc);
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
        [Route("DeleteDoctor")]
        public async Task<IActionResult> DeleteDoctor(int DocId)
        {
            try
            {
                var count = await DoctRef.DeleteDoctor(DocId);
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
