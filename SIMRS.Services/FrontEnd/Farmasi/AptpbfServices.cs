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
    public class AptpbfServices : IDisposable
    {

        #region constructor
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public AptpbfServices()
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

        public async Task<(IEnumerable<aptpbf>, string)> SelectAllAptpbfAsync()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptpbfRepository.GetAllAsync();
                }
            }

        }

        public string InsertUpdateAptpbf(aptpbf obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptpbfRepository.Save(obj);
                    if (!string.IsNullOrEmpty(data.Item2))
                        return data.Item2;
                    uow.Commit();
                    return data.Item2;
                }
            }
        }

        public string DeleteAptpbf(aptpbf obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptpbfRepository.Delete(obj);
                    if (!string.IsNullOrEmpty(data))
                        return data;
                    uow.Commit();
                    return data;
                }
            }
        }
    }
}
