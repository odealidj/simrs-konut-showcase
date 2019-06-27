using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.Farmasi
{
    public class ListbarangServices : IDisposable
    {

        #region constructor
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public ListbarangServices()
        {
            //context = new DapperContext();
            //uow = new UnitOfWork(context);
        }
        #endregion constructor

        #region disposable
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

        #endregion disposable

        public async Task<(IEnumerable<v_aptbarang>, string)> SelectAll_v_aptbarang_ByPageIndex(int pageIndex, int pageSize, string filtered)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptbarangRepository.GetAll_v_aptbarang_ByPageIndex(pageIndex, pageSize, filtered);
                }
            }
        }

        public async Task<(IEnumerable<v_aptbarang>, string)> GetAll_v_aptbarang_ByPageIndexAndAptdef1id(int pageIndex, int pageSize, string aptdef1id)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptbarangRepository.GetAll_v_aptbarang_ByPageIndexAndAptdef1id(pageIndex, pageSize, aptdef1id);
                }
            }
        }

    }
}
