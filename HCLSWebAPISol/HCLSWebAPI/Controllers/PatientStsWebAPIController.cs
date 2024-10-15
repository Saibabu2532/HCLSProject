using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Threading.Tasks;

namespace HCLSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientStsWebAPIController : ControllerBase
    {
        public IPatientStatusRepository IPsntstsRef;
        public PatientStsWebAPIController(IPatientStatusRepository _ipntstsRef)
        {
            IPsntstsRef = _ipntstsRef;
        }

        [HttpGet]
        [Route("GetAllPatientStatuses")]

        public async Task<IActionResult> GetAllPatientStatuses()
        {
            try
            {
             var PntstsList = await IPsntstsRef.GetAllPatientStatuses();
                if(PntstsList.Count > 0)
                {
                    return Ok(PntstsList);
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

        [HttpGet]
        [Route("GetPatientStatusById")]
        public async Task<IActionResult> GetPatientStatusById(int StatID)
        {
            try
            {
                var pststs = await IPsntstsRef.GetPatientStatusById(StatID);
                if (pststs != null)
                {
                    return Ok(pststs);
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
        [Route("InsertPatientStatus")]
        public async Task<IActionResult> InsertPatientStatus([FromBody] PatientStatus patientsts)
        {
            try
            {
                var count = await IPsntstsRef.InsertPatientStatus(patientsts);
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
        [Route("UpdatePatientStatus")]
        public async Task<IActionResult> UpdatePatientStatus([FromBody] PatientStatus patientsts)
        {
            try
            {
                var count = await IPsntstsRef.UpdatePatientStatus(patientsts);
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
        [Route("DeletePatientStatus")]
        public async Task<IActionResult> DeletePatientStatus(int StatID)
        {
            try
            {
                var count = await IPsntstsRef.DeletePatientStatus(StatID);
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

