using HMSAdmin.DBO.Models;
using HMSAdmin.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMSAdmin.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NurseController : ControllerBase
    {
        private readonly IAdmin<Nurse> nurseserv;


        public NurseController(IAdmin<Nurse> service)
        {
            nurseserv = service;
        }

        [HttpGet]
        [Route("nurse-listing")]
        public async Task<IActionResult> GetAsync()
        {
            var result = await nurseserv.GetAsync();
            return Ok(result);
        }

        [HttpGet("getnurse/{id}")] // the id is accepted in Header as URL Parameter
        public async Task<IActionResult> GetAsync(string id)
        {
            var result = await nurseserv.GetAsync(id);
            return Ok(result);
        }

        [HttpPut("updatenurse/{id}")] // the id is accepted in Header as URL Parameter
        public async Task<IActionResult> PutAsync(string id, string status)
        {
            if (ModelState.IsValid)
            {
                var result = await nurseserv.UpdateAsync(id, status);
                return Ok(result);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


    }
}
