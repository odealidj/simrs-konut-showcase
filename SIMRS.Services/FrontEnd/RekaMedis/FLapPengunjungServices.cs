using SIMRS.DA;
using SIMRS.DA.Expand;
using SIMRS.DA.IRepository;
using SIMRS.Model.customobject.rekammedis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.RekaMedis
{
    public class FLapPengunjungServices : IDisposable
    {
        #region constructor

        protected IDapperContext context;
        protected IUnitOfWork uow;

        public FLapPengunjungServices()
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

        public async Task<(IEnumerable<copengunjung>, string)> SelectAllPengunjung(int thn, int bln)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PengunjungRepository.getAllPengunjung(thn, bln);
                }
            }
        }
    }
}
