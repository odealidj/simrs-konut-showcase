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
    public class ListTindakanPasienServices : IDisposable
    {

        protected IDapperContext context;
        protected IUnitOfWork uow;

        public ListTindakanPasienServices()
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

        public async Task<(IEnumerable<v_pelayananpasien>, string)> SelectVpelayananpasienByRegistrasiIdAsync(short registrasiid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PelayananpasienRepository.GetAllVpelayananpasienByRegistrasiIdAsync(registrasiid);
                }
            }

        }
        public async Task<(IEnumerable<v_jenistarifpenjamin>, string)> SelectVjenistarifpenjaminByPenjaminIdAsync(short penjaminid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.JenistarifRepository.GetAllVjenistarifpenjaminByPenjaminIdAsync(penjaminid);
                }
            }
        }

        public (IEnumerable<v_jenistarifpenjamin>, string) SelectVjenistarifpenjaminByPenjaminId(short penjaminid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.JenistarifRepository.GetAllVjenistarifpenjaminByPenjaminId(penjaminid);
                }
            }
        }



        public int InsertPelayananPasien(pelayananpasien obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.PelayananpasienRepository.Save(obj);
                }
            }
        }

        public int DeletePelayananPasien(pelayananpasien obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var result = uow.PelayananpasienRepository.Delete(obj);
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
