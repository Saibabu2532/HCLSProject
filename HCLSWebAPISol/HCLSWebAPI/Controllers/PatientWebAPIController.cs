using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography;

namespace HCLSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientWebAPIController : ControllerBase
    {
        public IPatientRepository IPtnRef;
        public PatientWebAPIController(IPatientRepository _iPtnRef)
        {
            IPtnRef = _iPtnRef;
        }

        [HttpGet]
        [Route("AllPatients")]
        public async Task<IActionResult> AllPatients()
        {
            try
            {
                var Listptn = await IPtnRef.AllPatients();
                if (Listptn.Count > 0)
                {
                    return Ok(Listptn);
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
        [Route("PatientById")]
        public async Task<IActionResult> PatientById(int PatientID)
        {
            try
            {
                var Psnt = await IPtnRef.PatientById(PatientID);
                if (Psnt != null)
                {
                    return Ok(Psnt);
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
        [Route("InsertPatient")]
        public async Task<IActionResult> InsertPatient([FromBody] Patient Patnt)
        {
            try
            {
                var count = await IPtnRef.InsertPatient(Patnt);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return BadRequest("Records are Not Inserted in Database.....!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Somethig went Wrong ..!\n" + "Issue : " + ex.Message + ".\nwe will solve this issue soon ...1");
            }

        }

        [HttpPut]
        [Route("UpdatePatient")]
        public async Task<IActionResult> UpdatePatient([FromBody] Patient Patnt)
        {
            try
            {
                var count = await IPtnRef.UpdatePatient(Patnt);
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
        [Route("DeletePatient")]
        public async Task<IActionResult> DeletePatient(int PatientID)
        {
            try
            {
                var count = await IPtnRef.DeletePatient(PatientID);
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
        [HttpGet]
        [Route("GetLoginByEmailAndPassword")]

        public async Task<IActionResult> GetLoginByEmailAndPassword(string email, string password)
        {
            try
            {
                var Psnt = await IPtnRef.GetLoginByEmailAndPassword(email, password);
                return Ok(Psnt);
            }
            catch (Exception ex)
            {
                return BadRequest("Somethig went Wrong ..!\n" + "Issue : " + ex.Message + ".\nwe will solve this issue soon ...1");
            }
        }

        [HttpGet]
        [Route("HelperIdByPatient")]

        public  async Task<IActionResult> HelperIdByPatient(int HelpId)
        {
            try
            {
                var Listptn = await IPtnRef.HelperIdByPatient(HelpId);
                if (Listptn.Count > 0)
                {
                    return Ok(Listptn);
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
        [Route("LabIdByPatient")]

        public async Task<IActionResult> LabIdByPatient(int LabId)
        {
            try
            {
                var Listptn = await IPtnRef.LabIdByPatient(LabId);
                if (Listptn.Count > 0)
                {
                    return Ok(Listptn);
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
        [Route("ReceptionIdByPatient")]

        public async Task<IActionResult> ReceptionIdByPatient(int RecpId)
        {
            try
            {
                var Listptn = await IPtnRef.ReceptionIdByPatient(RecpId);
                if (Listptn.Count > 0)
                {
                    return Ok(Listptn);
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
        [Route("DoctorIdByPatient")]

        public async Task<IActionResult> DoctorIdByPatient(int DocId)
        {
            try
            {
                var Listptn = await IPtnRef.DoctorIdByPatient(DocId);
                if (Listptn.Count > 0)
                {
                    return Ok(Listptn);
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
        [Route("DocSpecIdByPatient")]

        public async Task<IActionResult> DocSpecIdByPatient(int DocSpecId)
        {
            try
            {
                var Listptn = await IPtnRef.DocSpecIdByPatient(DocSpecId);
                if (Listptn.Count > 0)
                {
                    return Ok(Listptn);
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
        [Route("PatienStsIdByPatient")]

        public async Task<IActionResult> PatienStsIdByPatient(int StatID)
        {
            try
            {
                var Listptn = await IPtnRef.PatienStsIdByPatient(StatID);
                if (Listptn.Count > 0)
                {
                    return Ok(Listptn);
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

    }
}
