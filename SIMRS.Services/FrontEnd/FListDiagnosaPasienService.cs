using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd
{
    public class FListDiagnosaPasienService :IDisposable
    {
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public FListDiagnosaPasienService()
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


        public async Task<(IEnumerable<dokter>, string)> SelectDokterAsync()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.DokterRepository.GetAllAsync();
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

    }
}
