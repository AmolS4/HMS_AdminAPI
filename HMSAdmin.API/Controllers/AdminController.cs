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


        [HttpPut("updatepatient/{id}")] // the id is accepted in Header as URL Parameter
        public async Task<IActionResult> PutAsync(string id, Patient data)
        {
            if (ModelState.IsValid)
            {
                var result = await adminServ.UpdateAsync(id, data);
                return Ok(result);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}
