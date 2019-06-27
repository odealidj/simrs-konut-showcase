using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd
{
    public class PerawatServices : IDisposable
    {
        #region constructor

        protected IDapperContext context;
        protected IUnitOfWork uow;

        public PerawatServices()
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

        # endregion

        public async Task<(IEnumerable<v_perawat>, string)> SelectVperawatAsync()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                     
                    return await uow.PerawatRepository.GetAllVperawatAsync();
                }
            }
        }

        public async Task<(IEnumerable<v_perawat>, string)> SelectVperawatAsync(short ruangrawatid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {

                    return await uow.PerawatRepository.GetAllVperawatAsync(ruangrawatid);
                }
            }
        }
    }
}
