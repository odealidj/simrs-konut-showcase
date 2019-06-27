using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services
{
    public class CaraPulangServices : IDisposable
    {
        //static string ErrResult;

        protected IDapperContext context;
        protected IUnitOfWork uow;

        #region Constructor
        public CaraPulangServices()
        {
            //context = new DapperContext();
            //uow = new UnitOfWork(context);
        }

        #endregion Constructor

        #region implement IDisposable
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

        #endregion implement IDisposable

        public async Task<(IEnumerable<carapulang>, string)> SelectAllCarapulangByPelayananmedikIdAsync(short pelayananmedikid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.CarapulangRepository.GetAllByPelayananmedikIdAsync(pelayananmedikid);
                }
            }
        }
    }
}
