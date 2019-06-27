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
    public class PengobatanServices : IDisposable
    {

        #region constructor

        protected IDapperContext context;
        protected IUnitOfWork uow;

        public PengobatanServices()
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

        #endregion

        public int InsertPengobatanPasien(pengobatan obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var result = uow.PengobatanRepository.Save(obj);
                    if (result == -99)
                    {
                        return -99;
                    }
                    uow.Commit();
                    return result;
                }
            }
        }

        public bool DeletePengobatanPasien(pengobatan obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var result = uow.PengobatanRepository.Delete(obj);
                    if (result == false)
                    {
                        return result;
                    }
                    uow.Commit();
                    return result;
                }
            }
        }

        public async Task<(IEnumerable<v_pengobatan>, string)> SelectAllv_pengobatanByRegistrasiruangrawatidAsync(short registrasiruangrawatid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PengobatanRepository.GetAllv_pengobatanByRegistrasiruangrawatidAsync(registrasiruangrawatid);
                }
            }
        }

        public (IEnumerable<pengobatanaturanpakai>, string) SelectAllPengobatanaturanpakai()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.PengobatanRepository.GetAllPengobatanaturanpakai();
                }
            }
        }

        public (IEnumerable<pengobatannama>, string) SelectAllPengobatannama()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.PengobatanRepository.GetAllPengobatannama();
                }
            }
        }

        public (IEnumerable<pengobatansatuan>, string) SelectAllPengobatansatuan()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.PengobatanRepository.GetAllPengobatansatuan();
                }
            }
        }

        public (IEnumerable<pengobatanukuran>, string) SelectAllPengobatanukuran()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.PengobatanRepository.GetAllPengobatanukuran();
                }
            }
        }

    }
}
