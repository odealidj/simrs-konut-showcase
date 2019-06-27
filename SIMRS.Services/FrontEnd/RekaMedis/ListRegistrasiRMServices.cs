using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.RekaMedis
{
    public class ListRegistrasiRMServices : IDisposable
    {
        protected IDapperContext context;
        protected IUnitOfWork uow;

        #region constructor
        public ListRegistrasiRMServices()
        {
            //context = new DapperContext();
            //uow = new UnitOfWork(context);
        }
        #endregion

        #region iDispose
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

        public async Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)>SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize,DateTime tglmasuk)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiRepository.GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize, tglmasuk);
                }
            }
        }

        public async Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, DateTime tglmasuk,int? stsmasukkeluar)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiRepository.GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize, tglmasuk,stsmasukkeluar);
                }
            }
        }

        public async Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, DateTime tglmasuk, string value)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiRepository.GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize, tglmasuk, value);
                }
            }
        }

        public async Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, DateTime tglmasuk, string value, int? stsmasukkeluar)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiRepository.GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize, tglmasuk, value, stsmasukkeluar);
                }
            }
        }

        public async Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize,string value)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiRepository.GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize,value);
                }
            }
        }

        public async Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, string value, int? stsmasukkeluar)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiRepository.GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize, value,stsmasukkeluar);
                }
            }
        }

        public async Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiRepository.GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize);
                }
            }
        }

        public async Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> SelectAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, int? stsmasukkeluar)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiRepository.GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(pageIndex, pageSize, stsmasukkeluar);
                }
            }
        }

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> SelectAllv_registrasiruangrawatByRegistrasiidAsync(short registrasiid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiruangrawatRepository.GetAllv_registrasiruangrawatByRegistrasiidAsync(registrasiid);
                }
            }
        }

        public async Task<(v_identitaspasien_for_listregistrasi, string)> FirtOrDefaultVidentitaspasien_for_listregistrasiByNoCMAsync(string nocm)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.ListRegistrasiRepository.GetVidentitaspasien_for_listregistrasiByNoCMAsync(nocm);
                }
            }
        }
    }
}
