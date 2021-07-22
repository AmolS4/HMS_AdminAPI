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
    public class PhysicianController : ControllerBase
    {
        private readonly IAdmin<Physician> physicianserv;


        public PhysicianController(IAdmin<Physician> service)
        {
            physicianserv = service;
        }

        [HttpGet]
        [Route("physician-listing")]
        public async Task<IActionResult> GetAsync()
        {
            var result = await physicianserv.GetAsync();
            return Ok(result);
        }

        [HttpGet("getphysician/{id}")] // the id is accepted in Header as URL Parameter
        public async Task<IActionResult> GetAsync(string id)
        {
            var result = await physicianserv.GetAsync(id);
            return Ok(result);
        }


        [HttpPut("updatephysician/{id}")] // the id is accepted in Header as URL Parameter
        public async Task<IActionResult> PutAsync(string id, string status)
        {
            if (ModelState.IsValid)
            {
                var result = await physicianserv.UpdateAsync(id, status);
                return Ok(result);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


    }
}
