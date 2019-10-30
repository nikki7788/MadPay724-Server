using MadPay724.Data.Repositories.Interface;
using MadPay724.Data.Repositories.Repo;
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
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext, new()
    {
        #region ######### Dependencies ############

        protected readonly DbContext _db;
        public UnitOfWork()
        {
            _db = new TContext();
        }
        #endregion ########

        #region ########## Methods##############

        #region ************Private Repository**********

        private IUserRepository userRepository;

        public IUserRepository UserRepository
        {

            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(_db);
                }
                return userRepository;
            }
        }

        #endregion


        #region ****save******
        /// <summary>
        /// ذخیره معمولی
        /// </summary>
        public void Save()
        {
            _db.SaveChanges();
        }

        /// <summary>
        /// ذخیره غیرهمزمان
        /// </summary>
        /// <returns></returns>
        public Task<int> SaveAsync()
        {
            return _db.SaveChangesAsync();
        }

        #endregion *******


        #region *********IDisposable Support********
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    _db.Dispose();

                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }
        /// <summary>
        /// مخرب کلاس
        /// </summary>
        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~UnitOfWork()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion ******

        #endregion #########
    }
}
