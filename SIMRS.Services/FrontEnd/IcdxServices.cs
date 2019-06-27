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
    public class IcdxServices : IDisposable
    {
                
        #region contructor
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public IcdxServices()
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


        #endregion constructor


        public int InsertIcdxpasien(icdxpasien obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var result = uow.IcdxpasienRepository.Save(obj);
                    if (result == -99)
                    {
                        return -99;
                    }
                    uow.Commit();
                    return result;
                }
            }
        }

        public int DeleteIcdxpasien(icdxpasien obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var result = uow.IcdxpasienRepository.Delete(obj);
                    if (result == false)
                    {
                        return -99;
                    }
                    uow.Commit();
                    return 1;
                }
            }
        }

        public async Task<(IEnumerable<v_icdxpasienpoli>, string)> SelectVicdxpasienpoliAsync(short registrasiruangrawatid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.IcdxpasienRepository.GetAllVicdxpasienpoliAsync(registrasiruangrawatid);
                }
            }
        }

        public async Task<(IEnumerable<jenisdiagnosa>, string)> SelectJenisdiagnosaAsync()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.JenisdiagnosaRepository.GetAllAsync();
                }
            }
        }

    }
}
