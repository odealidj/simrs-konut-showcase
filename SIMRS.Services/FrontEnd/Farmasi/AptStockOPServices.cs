using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.Farmasi
{
    public class AptStockOPServices : IDisposable
    {

        #region constructor
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public AptStockOPServices()
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

        public async Task<(IEnumerable<v_aptbrggudetail_notin_stock>, string)> SelectAll_v_aptbrggudetail_notin_stock()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptstockopRepository.GetAll_v_aptbrggudetail_notin_stock(); 
                    
                }
            }
        }

        public string InsertStockOP(aptstockop obj, List<v_aptbrggudetail_notin_stock> v_Aptbrggudetail_Notin_Stocks)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptstockopRepository.Save(obj);
                    if (!string.IsNullOrEmpty(data.Item2))
                        return data.Item2;
                    
                    foreach (v_aptbrggudetail_notin_stock item in v_Aptbrggudetail_Notin_Stocks)
                    {
                        var data2 = uow.AptstockopdetaildRepository.Save(
                                new aptstockopdetaild
                                {
                                    aptstockopdetailid = (short)-1,
                                    aptstockopid = short.Parse(data.Item1.ToString()),
                                    aptbrggudetailid = item.aptbrggudetailid,
                                    jmlstock = short.Parse(item.jmlbrg.Value.ToString())
                                }
                            );
                        if (!string.IsNullOrEmpty(data2.Item2))
                            return data2.Item2;
                    }
                    
                    uow.Commit();
                    return data.Item2;
                }
            }
        }

        public async Task<(IEnumerable<v_aptstockkontrol>, string)> SelectAll_v_aptstockkontrol()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptstockopdetaildRepository.GetAll_v_aptstockkontrol();

                }
            }
        }
    }
}
