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


        public bool AddAllergyData(AllergyData model)
        {
            bool success = false;
            try
            {
                Allergy allergy = new Allergy()
                {
                    AllergyName = model.AllergyName,
                    AllergyDescription = model.AllergyDescription,
                    AllergyType = model.AllergyType,

                };
                context.Allergy.Add(allergy);
                context.SaveChanges();

            }
            catch (Exception ex )
            {

                throw;
            }
            return success;
        }






        public bool AddDiagnosisData(DianosisData model)
        {
            bool success = false;
            try
            {
                Diagnosis diagnosisdata = new Diagnosis()
                {


                    //DiagnosisType = model.DiagnosisType,
                    DiagnosisDescription = model.DiagnosisDescription,
                    DiagnosisIsDepricated = model.IsDepricated
                    // ActiveIngredient = model.ActiveIngredient,


                   };
                context.Diagnosis.Add(diagnosisdata);
                context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
            return success;
        }

        public bool AddMedicationData(MedicationData model)
        {
            bool success = false;
            try
            {
                DrugData drugdata = new DrugData()
                {


                    DrugName = model.DrugName,
                    DrugForm = model.DrugForm,
                    DrugStrength = model.DrugStrength,
                   // ActiveIngredient = model.ActiveIngredient,
                    DrugManufacturerName = model.DrugManufacturerName



                };
                context.DrugData.Add(drugdata);
                context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
            return success;
        }

        public bool AddProcedureData(ProcedureData model)
        {
            bool success = false;
            try
            {
                Procedure procedure = new Procedure()
                {
                   

                    ProcedureCode  = model.ProcedureCode,
                    ProcedureDescription=model.ProcedureDescription,
                    ProcedureIsDepricated = model.IsProcedureDepricated
                      


                 };
                context.Procedure.Add(procedure);
                context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
            return success;
        }

        public List<AllergyData> GetAllergyDetail()
        {
            var result = context.Allergy.Select(e => new AllergyData
            {



                AllergyId=e.AllergyId, 
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

                DiagnosisId=e.DiagnosisId, 
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
