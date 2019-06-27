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
    public class AnamnesaServices : IDisposable
    {

        #region constructor

        protected IDapperContext context;
        protected IUnitOfWork uow;

        public AnamnesaServices()
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


        public int InsertAnamnesaPasien(anamnesapasien obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var result = uow.AnamnesapasienRepository.Save(obj);
                    if (result == -99)
                    {
                        return -99;
                    }
                    uow.Commit();
                    return result;
                }
            }
        }

        public bool DeleteAnamnesaPasien(anamnesapasien obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var result = uow.AnamnesapasienRepository.Delete(obj);
                    if (result == false)
                    {
                        return result;
                    }
                    uow.Commit();
                    return result;
                }
            }
        }

        public async Task<(IEnumerable<v_anamnesapasien>, string)> SelectAllv_anamnesapasienByRegistrasiruangrawatidAsync(short registrasiruangrawatid,DateTime tglperiksa)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AnamnesapasienRepository.GetAllv_anamnesapasienByRegistrasiruangrawatidAsync(registrasiruangrawatid,tglperiksa);
                }
            }
        }

        public async Task<(IEnumerable<v_anamnesapasien>, string)> SelectAllv_anamnesapasienByRegistrasiruangrawatidAsync(short registrasiruangrawatid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AnamnesapasienRepository.GetAllv_anamnesapasienByRegistrasiruangrawatidAsync(registrasiruangrawatid);
                }
            }
        }
    }
}
