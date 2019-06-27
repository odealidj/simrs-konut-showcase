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
    public class ListIdentitasPasienServices : IDisposable
    {
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public ListIdentitasPasienServices()
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

        public async Task<(IEnumerable<v_identitaspasien_jk_alamatpasien>, string)> SelectVidentitaspasien_jk_alamatpasienByPageIndexAsync(int pageIndex, int pageSize)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.IdentitaspasienRepository.GetAllv_identitaspasien_jk_alamatpasienByPageIndexAsync(pageIndex, pageSize);
                }
            }
        }

        public async Task<(IEnumerable<v_identitaspasien_jk_alamatpasien>, string)> SelectVidentitaspasien_jk_alamatpasienByPageIndexAndFilterByNocmNamaAsync(int pageIndex, int pageSize, string value)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.IdentitaspasienRepository.GetAllv_identitaspasien_jk_alamatpasienByPageIndexAndFilterByNocmNamaAsync(pageIndex, pageSize, value);
                }
            }
        }

        public async Task<(IEnumerable<v_identitaspasien_jk_alamatpasien>, string)> SelectVidentitaspasien_jk_alamatpasienByPageIndexAndFilterByTglLahirAsync(int pageIndex, int pageSize, string value)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.IdentitaspasienRepository.GetAllv_identitaspasien_jk_alamatpasienByPageIndexAndFilterByTglLahirAsync(pageIndex, pageSize, value);
                }
            }
        }

        public async Task<(v_identitaspasien_for_listidentitaspasien, string)> FirtOrDefaultVidentitaspasien_for_listidentitaspasienByNoCMAsync(string nocm)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.IdentitaspasienRepository.GetVidentitaspasien_for_listidentitaspasienByNoCMAsync(nocm);
                }
            }
        }

    }
}
