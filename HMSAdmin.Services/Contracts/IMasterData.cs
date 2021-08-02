using HMSAdmin.DBO.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMSAdmin.Services.Contracts
{
    public interface IMasterData
    {

       List<DianosisData> GetDiagnosisDetail();

        List<MedicationData> GetMedicationDetail();
        List<ProcedureData> GetProcedureDetail();
        List<AllergyData> GetAllergyDetail();


        bool AddDiagnosisData(DianosisData model);

        bool AddMedicationData(MedicationData model);
        bool AddProcedureData(ProcedureData model);
        bool AddAllergyData(AllergyData model);

    }
}
