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
    public class MasterDataController : ControllerBase
    {

        private readonly IMasterData masterServ;
         

        public MasterDataController(IMasterData service)
        {
            masterServ = service;
        }

        [HttpGet]
        [Route("Allergy-listing")]
        public IActionResult GetAllergy()
        {
            var result =  masterServ.GetAllergyDetail();
            return Ok(result);
        }

        [HttpGet]
        [Route("Diagnosis-listing")]
        public IActionResult GetDiagnosis()
        {
            var result = masterServ.GetDiagnosisDetail();
            return Ok(result);
        }

        [HttpGet]
        [Route("Medication-listing")]
        public IActionResult GetMedication()
        {
            var result = masterServ.GetMedicationDetail();
            return Ok(result);
        }

        [HttpGet]
        [Route("Procedure-listing")]
        public IActionResult GetProcedure()
        {
            var result = masterServ.GetProcedureDetail();
            return Ok(result);
        }




    }
}
