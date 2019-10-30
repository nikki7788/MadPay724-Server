using MadPay724.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MadPay724.Data.Infrastructure
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
  public  interface IUnitOfWork<TContext> :IDisposable where TContext : DbContext 
    {
        IUserRepository UserRepository { get; }


        void Save();
        Task<int> SaveAsync();
    }
}
