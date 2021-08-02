using HMSAdmin.DBO.Models;
using HMSAdmin.DBO.Providers;
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
    public class AdminController : ControllerBase
    {
        private readonly IAdmin<Patient> adminServ;


        public AdminController(IAdmin<Patient> service)
        {
            adminServ = service;
        }

        [HttpGet]
        [Route("patient-listing")]
        public async Task<IActionResult> GetAsync()
        {
            var result = await adminServ.GetAsync();
            return Ok(result);
        }

        [HttpGet("getpatient/{id}")] // the id is accepted in Header as URL Parameter
        public async Task<IActionResult> GetAsync(string id)
        {
            var result = await adminServ.GetAsync(id);
            return Ok(result);
        }


        //[HttpPost("updatepatient/{id}")] // the id is accepted in Header as URL Parameter
        //[HttpPost,Route("updatepatient")]
        [HttpPut, Route("updatepatient")]
        public IActionResult updatestatus([FromBody] Status patient)
        {
            if (ModelState.IsValid)
            {
                var result =  adminServ.UpdateAsync(patient);
                return Ok(result);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        //[HttpPut("updatestatus/{id}")] // the id is accepted in Header as URL Parameter
        //public async Task<IActionResult> updatestatus(string id, string status)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await adminServ.UpdateAsync(id, status);
        //        return Ok(result);
        //    }
        //    else
        //    {
        //        return BadRequest(ModelState);
        //    }
        //}

    }
}
