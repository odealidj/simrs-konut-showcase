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
    public class AptsatuanServices : IDisposable
    {

        #region constructor
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public AptsatuanServices()
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

        public async Task<(IEnumerable<aptsatuan>, string)> SelectAllAptsatuanAsync(string filtered)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptsatuanRepository.GetAllAsync(filtered);
                }
            }

        }

        public async Task<(IEnumerable<aptsatuan>, string)> SelectAllNotInKodeAsync(string aptsatuankode)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptsatuanRepository.GetAllNotInKodeAsync(aptsatuankode);
                }
            }

        }

        public aptsatuan Get(aptsatuan obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.AptsatuanRepository.Get(obj);
                }
            }

        }

        public string InsertUpdateAptsatuan(aptsatuan obj, string newaptsatuankode)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptsatuanRepository.Save(obj, newaptsatuankode);
                    if (!string.IsNullOrEmpty(data.Item2))
                        return data.Item2;
                    uow.Commit();
                    return data.Item2;
                }
            }
        }

        public string DeleteAptsatuan(aptsatuan obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptsatuanRepository.Delete(obj);
                    if (!string.IsNullOrEmpty(data))
                        return data;
                    uow.Commit();
                    return data;
                }
            }
        }
    }
}
