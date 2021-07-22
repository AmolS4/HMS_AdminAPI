using System;
using System.Collections.Generic;
using System.Text;

namespace HMSAdmin.DBO.Providers
{
    public class MasterData
    {

      

    }

    public class MedicationData
    {

        public int DrugId { get; set; }

        public string DrugName { get; set; }

        public string DrugForm { get; set; }

        public string DrugStrength { get; set; }

        public string ActiveIngredient { get; set; }

        public string DrugManufacturerName{ get; set; }

    }

    public class AllergyData
    {
        public string AllergyId { get; set; }
        public string AllergyType { get; set; }
        public string AllergyName { get; set; }

        public string AllergyDescription { get; set; }

    }
    public class DianosisData
    {
        public string DiagnosisId { get; set; }

        public string DiagnosisType { get; set; }
        public string DiagnosisDescription { get; set; }

        public bool? IsDepricated { get; set; }
    }
    public class ProcedureData
    {
        public int ProcedureId { get; set; }

        public string ProcedureCode { get; set; }

        public string ProcedureDescription { get; set; }

        public bool? IsProcedureDepricated { get; set; }

    }
}
