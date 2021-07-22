using HMSAdmin.DBO.Models;
using HMSAdmin.DBO.Providers;
using HMSAdmin.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HMSAdmin.Services.Services
{
    public class MasterService : IMasterData
    {
        private HospitalManagementContext context;

        public MasterService(HospitalManagementContext c)
        {

            context = c;
        }

        //public bool AddAllergyData(AllergyData model)
        //{
        //    bool success = false;
        //    try
        //    {
        //        Allergy allergy = new Allergy()
        //        {
        //            AllergyName = model.AllergyName,
        //            AllergyDescription = model.AllergyDescription,
        //            AllergyType = model.AllergyType,

        //            context.Allergy.Add(model);
        //        context.SaveChanges();
        //       }
        //    }
        //    return success;

        // }


        public bool AddAllergyData()
        {
            //bool success = false;
            //try
            //{
            //    Allergy allergy = new Allergy()
            //    {


            //    };

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            throw new NotImplementedException();
        }






    public bool AddDiagnosisData()
        {
            throw new NotImplementedException();
        }

        public bool AddMedicationData()
        {
            throw new NotImplementedException();
        }

        public bool AddProcedureData()
        {
            throw new NotImplementedException();
        }

        public List<AllergyData> GetAllergyDetail()
        {
            var result = context.Allergy.Select(e => new AllergyData
            {



               //AllergyId=e.AllergyId, data type in string
                AllergyName=e.AllergyName,
                AllergyDescription=e.AllergyDescription,
                AllergyType=e.AllergyType
               

              }).ToList();

            return result;
        }

        public List<DianosisData> GetDiagnosisDetail()
        {
            var result = context.Diagnosis.Select(e => new DianosisData
            {

               // DiagnosisId=e.DiagnosisId, data type string change
                DiagnosisDescription =e.DiagnosisDescription,
                IsDepricated=e.DiagnosisIsDepricated
                //DiagnosisType


             }).ToList();

            return result;
        }

        public  List<MedicationData> GetMedicationDetail()
        {
            var result = context.DrugData.Select(e => new MedicationData
            {
                DrugManufacturerName = e.DrugManufacturerName,
                DrugForm = e.DrugForm,
                DrugId = e.DrugId,
                DrugName = e.DrugName,
                DrugStrength=e.DrugStrength
               // ActiveIngredient

              }).ToList();
            
            return result;
        }

        public List<ProcedureData> GetProcedureDetail()
        {
            var result = context.Procedure.Select(e => new ProcedureData
            {

                ProcedureId = e.ProcedureId,
                ProcedureCode = e.ProcedureCode,
                ProcedureDescription = e.ProcedureDescription,
                IsProcedureDepricated = e.ProcedureIsDepricated

               }).ToList();

            return result;
        }
    }
}
