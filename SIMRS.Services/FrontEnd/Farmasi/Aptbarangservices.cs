using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.Farmasi
{
    public class Aptbarangservices : IDisposable
    {

        #region constructor
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public Aptbarangservices()
        {
            //context = new DapperContext();
            //uow = new UnitOfWork(context);
        }
        #endregion constructor

        #region disposable
        public void Dispose()
        {
            if (uow != null)
            {
                try
                {
                }
                finally
                {
                    uow.Dispose();
                }
            }
            if (context != null)
            {
                try
                {
                }
                finally
                {
                    context.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }

        #endregion disposable

        
        public async Task<(IEnumerable<aptbarang>, string)> SelectAllAsync()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    
                    return await uow.AptbarangRepository.GetAllAsync();
                }
            }
        }

        public string InsertUpdateAptbarang(aptbarang obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptbarangRepository.Save(obj);
                    if (!string.IsNullOrEmpty(data.Item2))
                        return data.Item2;
                    uow.Commit();
                    return data.Item2;
                }
            }
        }

        public string DeleteAptbarang(aptbarang obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptbarangRepository.Delete(obj);
                    if (!string.IsNullOrEmpty(data))
                        return data;
                    uow.Commit();
                    return data;
                }
            }
        }





    }
}
