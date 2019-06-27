using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.Registrasi
{
    public class ListRegistrasiServices : IDisposable
    {
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public ListRegistrasiServices()
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

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> SelectVregistrasiByPageIndexAndPelayananmedikIdAndFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid,short stsregistrasiid, string value)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiruangrawatRepository.GetAllVregistrasiByPageIndexAndPelayananmedikIdAndFilterByNocmNoregNamaAsync(pageIndex, pageSize, pelayananmedikid,stsregistrasiid, value);
                }
            }
        }

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> SelectVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, 
                short ruangrawatid, 
                short stsregistrasiid, short stsmasukkeluarruangrawatid, string value)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiruangrawatRepository.GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(pageIndex, pageSize, pelayananmedikid, stsregistrasiid, ruangrawatid , stsmasukkeluarruangrawatid, value);
                }
            }
        }

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> SelectVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid,
        short ruangrawatid,
        short stsregistrasiid, short stsmasukkeluarruangrawatid, string value, DateTime tglmasuk)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiruangrawatRepository.GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(pageIndex, pageSize, pelayananmedikid, stsregistrasiid, ruangrawatid, stsmasukkeluarruangrawatid, value, tglmasuk);
                }
            }
        }

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> SelectVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid,
        short ruangrawatid , short stsmasukkeluarruangrawatid, string value, DateTime tglmasuk)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiruangrawatRepository.GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(pageIndex, pageSize, pelayananmedikid, ruangrawatid, stsmasukkeluarruangrawatid, value, tglmasuk);
                }
            }
        }

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> SelectVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaTglKeluarRuanganAsync(int pageIndex, int pageSize, short pelayananmedikid,
            short ruangrawatid, short stsmasukkeluarruangrawatid, string value, DateTime tglkeluarruangan)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiruangrawatRepository.GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaTglKeluarRuanganAsync(pageIndex, pageSize, pelayananmedikid, ruangrawatid, stsmasukkeluarruangrawatid, value, tglkeluarruangan);
                }
            }
        }

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> SelectVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid,
            short ruangrawatid, short stsmasukkeluarruangrawatid, string value)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiruangrawatRepository.GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(pageIndex, pageSize, pelayananmedikid, ruangrawatid, stsmasukkeluarruangrawatid, value);
                }
            }
        }


        public async Task<(IEnumerable<v_registrasiruangrawatrjrd>, string)> SelectVregistrasiruangrawatrjrdByPageIndexAndFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short stsregistrasiid, string value)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RegistrasiruangrawatRepository.GetAllVregistrasiruangrawatrjrdByPageIndexAndFilterByNocmNoregNamaAsync(pageIndex, pageSize, stsregistrasiid, value);
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

        public int UpdateStsMasukKeluarRuangRawat(short registrasiruangrawatid, short stsmasukkeluarruangrawatid,DateTime tglkeluarruangan, DateTime jamkeluarruangan)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var result = uow.RegistrasiruangrawatRepository.UpdateStsMasukKeluarRuangRawat(registrasiruangrawatid, stsmasukkeluarruangrawatid, tglkeluarruangan, jamkeluarruangan);
                    if (result == false)
                    {
                        return -99;
                    }
                    uow.Commit();
                    return 1;
                }
            }
        }

    }
}
