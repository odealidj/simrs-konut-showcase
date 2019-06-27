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
    public class RLServices : IDisposable
    {
        protected IDapperContext context;
        protected IUnitOfWork uow;

        #region constructor
        public RLServices()
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

        public async Task<(IEnumerable<v_RL_51_Pengunjung>, string)> SelectAllv_RL_51_PengunjungByThnAndBlnAsync(int thn, int bln)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RLRepository.GetAllv_RL_51_PengunjungByThnAndBlnAsync(thn,bln);
                }
            }
        }

        public async Task<(IEnumerable<v_RL_54>, string)> SelectAllv_RL_54ByThnAndBlnAsync(int thn, int bln)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RLRepository.GetAllv_RL_54ByThnAndBlnAsync(thn, bln);
                }
            }
        }
    }
}
