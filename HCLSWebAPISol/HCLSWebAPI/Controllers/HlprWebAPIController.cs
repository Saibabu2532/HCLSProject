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
    public class HlprWebAPIController : ControllerBase
    {
        public IHelpRepository HelpRef;
        public HlprWebAPIController(IHelpRepository helpRef)
        {
            HelpRef = helpRef;
        }

        [HttpGet]
        [Route("AllHelpers")]

        public async Task<IActionResult> AllHelpers()
        {
            try
            {
                var HelpList = await HelpRef.AllHelpers();
                if (HelpList.Count > 0)
                {
                    return Ok(HelpList);
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
        [Route("GetHelperByHelId")]

        public async Task<IActionResult> GetHelperByHelId(int HelpId)
        {
            try
            {
                var help = await HelpRef.GetHelperByHelId(HelpId);
                if (help != null)
                {
                    return Ok(help);
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
        [Route("InsertHelper")]

        public async Task<IActionResult> InsertHelper([FromBody] Helper help)
        {
            try
            {
                var count = await HelpRef.InsertHelper(help);
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
        [Route("UpdateHelper")]
        public async Task<IActionResult> UpdateHelper([FromBody] Helper help)
        {
            try
            {
                var count = await HelpRef.UpdateHelper(help);
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
        [Route("DeleteHelper")]
        public async Task<IActionResult> DeleteHelper(int HelpId)
        {
            try
            {
                var count = await HelpRef.DeleteHelper(HelpId);
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
