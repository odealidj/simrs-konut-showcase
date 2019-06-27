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
    public class PelayananpaseinServices : IDisposable
    {

        #region constructor

        protected IDapperContext context;
        protected IUnitOfWork uow;

        public PelayananpaseinServices()
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

        public async Task<(IEnumerable<v_tindakanpoli>, string)> SelectVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(short registrasiid, short ruangrawatid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PelayananpasienRepository.GetAllVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(registrasiid, ruangrawatid);
                }
            }
        }

        public async Task<(IEnumerable<v_tindakanpoli>, string)> SelectVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(short registrasiid, short ruangrawatid, DateTime tgltindakan)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PelayananpasienRepository.GetAllVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(registrasiid, ruangrawatid, tgltindakan);
                }
            }
        }


    }
}
