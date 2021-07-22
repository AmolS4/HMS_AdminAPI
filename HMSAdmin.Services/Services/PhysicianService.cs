using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HMSAdmin.DBO.Models;
using HMSAdmin.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace HMSAdmin.Services.Services
{
    public class PhysicianService : IAdmin<Physician>
    {

        private HospitalManagementContext context;

        public PhysicianService(HospitalManagementContext c)
        {

            context = c;
        }

        public async Task<IEnumerable<Physician>> GetAsync()
        {
            var result = await context.Physician.ToListAsync();
            return result;
        }

        public async Task<Physician> GetAsync(string id)
        {
            try
            {
                var result = await context.Physician.FindAsync(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Physician> UpdateAsync(string id, string status)
        {
            try
            {
                var result = await context.Physician.FindAsync(id);
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
