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
    public class AptdistribusiServices : IDisposable
    {

        #region constructor
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public AptdistribusiServices()
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

        public (IEnumerable<v_aptdistribusi>, string) SelectAllv_aptdistribusi()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.AptdistribusiRepository.GetAllv_aptdistribusi();
                }
            }
        }

        public (IEnumerable<v_aptdistribusi>, string) SelectAllv_aptdistribusi(string year, string month)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.AptdistribusiRepository.GetAllv_aptdistribusi(year, month);
                }
            }
        }

        public (IEnumerable<v_aptdistribusi>, string) SelectAllv_aptdistribusi(string depo)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.AptdistribusiRepository.GetAllv_aptdistribusi(depo);
                }
            }
        }


    }
}
