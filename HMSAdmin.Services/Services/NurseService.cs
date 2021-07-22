using HMSAdmin.DBO.Models;
using HMSAdmin.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HMSAdmin.Services.Services
{
    public class NurseService : IAdmin<Nurse>
    {
        private HospitalManagementContext context;

        public NurseService(HospitalManagementContext c)
        {

            context = c;
        }
        public async Task<IEnumerable<Nurse>> GetAsync()
        {
            var result = await context.Nurse.ToListAsync();
            return result;
        }

        public async Task<Nurse> GetAsync(string id)
        {
            try
            {
                var result = await context.Nurse.FindAsync(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Nurse> UpdateAsync(string id, string status)
        {
            try
            {
                var result = await context.Nurse.FindAsync(id);
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
