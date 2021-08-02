using HMSAdmin.DBO.Models;
using HMSAdmin.DBO.Providers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HMSAdmin.Services.Contracts
{
    public interface IAdmin<TEntity> where TEntity : class
    {

        Task<IEnumerable<TEntity>> GetAsync();
        Task<TEntity> GetAsync(string id);
        Task<TEntity> UpdateAsync(Status patient);
    }
}
