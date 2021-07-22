using HMSAdmin.DBO.Models;
using HMSAdmin.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HMSAdmin.Services.Services
{
    public class PatientService : IAdmin<Patient>
    {
        private HospitalManagementContext context;

        public PatientService(HospitalManagementContext c)
        {

            context = c;
        }
      
        public async Task<IEnumerable<Patient>> GetAsync()
        {
            var result = await context.Patient.ToListAsync();
            return result;
        }

        public async Task<Patient> GetAsync(string id)
        {
            try
            {
                var result = await context.Patient.FindAsync(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Patient> UpdateAsync(string id, string status)
        {
            try
            {
                var result = await context.Patient.FindAsync(id);
                if (result == null) throw new Exception($"Record not found, update operation is failed");


                result.Status = status;
               

                // modify the record 
                //context.Entry(result).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
