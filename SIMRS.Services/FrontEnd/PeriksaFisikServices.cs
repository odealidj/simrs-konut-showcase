using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd
{
    public class PeriksaFisikServices : IDisposable
    {
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public PeriksaFisikServices()
        {
            //context = new DapperContext();
            //uow = new UnitOfWork(context);
        }

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

        public int InsertPemeriksaanFisik(pemeriksaanfisik obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var result = uow.PemeriksaanfisikRepository.Save(obj);
                    if (result == -99)
                    {
                        return -99;
                    }
                    uow.Commit();
                    return result;
                }
            }
        }

        public bool DeletePemeriksaanFisik(pemeriksaanfisik obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var result = uow.PemeriksaanfisikRepository.Delete(obj);
                    if (result == false)
                    {
                        return result;
                    }
                    uow.Commit();
                    return result;
                }
            }
        }

        public async Task<(IEnumerable<pemeriksaanfisik>, string)> SelectAllAsync(short pemeriksaanfisikid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PemeriksaanfisikRepository.GetAllAsync(pemeriksaanfisikid);
                }
            }
        }

        public async Task<(IEnumerable<v_pemeriksaanfisik>, string)> SelectAllv_pemeriksaanfisikAsync(short pemeriksaanfisikid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PemeriksaanfisikRepository.GetAllv_pemeriksaanfisikAsync(pemeriksaanfisikid);
                }
            }
        }

        public async Task<(IEnumerable<v_pemeriksaanfisik>, string)> SelectAllv_pemeriksaanfisikByregistrasiruangrawatidAsync(short registrasiruangrawatid, DateTime tglpemeriksaanfisik)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PemeriksaanfisikRepository.GetAllv_pemeriksaanfisikByregistrasiruangrawatidAsync(registrasiruangrawatid, tglpemeriksaanfisik);
                }
            }
        }


    }
}
