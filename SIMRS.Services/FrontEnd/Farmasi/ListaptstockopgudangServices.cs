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
    public class ListaptstockopgudangServices : IDisposable
    {

        #region constructor
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public ListaptstockopgudangServices()
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

        public (IEnumerable<v_aptstockopgudang>, string) SelectAll_v_aptstockopgudangByYearAndMonth(short year, short month)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.AptstockopgudangRepository.GetAll_v_aptstockopgudangByYearAndMonth(year, month);
                }
            }
        }

        public (IEnumerable<v_aptstockopgudang>, string) SelectAll_v_aptstockopgudangByYearAndMonthAndKet(string value)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.AptstockopgudangRepository.GetAll_v_aptstockopgudangByYearAndMonthAndKet(value);
                }
            }
        }

        public (IEnumerable<v_aptstockopgudang>, string) SelectAll_v_aptstockopgudang()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.AptstockopgudangRepository.GetAll_v_aptstockopgudang();
                }
            }
        }

        public (IEnumerable<v_aptstockopgudangdetail>, string) SelectAll_v_aptstockopgudangdetailByAptstockopgudangId(short aptstockopgudangid, string filter)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    if (string.IsNullOrEmpty(filter))
                        return uow.AptstockopgudangdetailRepository.GetAll_v_aptstockopgudangdetailByAptstockopgudangId(aptstockopgudangid);
                    else
                        return uow.AptstockopgudangdetailRepository.GetAll_v_aptstockopgudangdetailByAptstockopgudangId(aptstockopgudangid, filter);
                }
            }
        }
    }
}
