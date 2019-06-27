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
    public class AptdepoServices : IDisposable
    {

        #region constructor
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public AptdepoServices()
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

        public async Task<(IEnumerable<aptdepo>, string)> SelectAllAptdepoAsync(string filtered)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptdepoRepository.GetAllAsync(filtered);
                }
            }

        }

        public string InsertUpdateAptdepo(aptdepo obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptdepoRepository.Save(obj);
                    if (!string.IsNullOrEmpty(data.Item2))
                        return data.Item2;
                    uow.Commit();
                    return data.Item2;
                }
            }
        }

        public string DeleteAptdepo(aptdepo obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptdepoRepository.Delete(obj);
                    if (!string.IsNullOrEmpty(data))
                        return data;
                    uow.Commit();
                    return data;
                }
            }
        }
    }
}
