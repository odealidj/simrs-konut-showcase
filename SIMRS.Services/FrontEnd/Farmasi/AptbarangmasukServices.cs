using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.Farmasi
{
    public class AptbarangmasukServices : IDisposable
    {

        #region constructor
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public AptbarangmasukServices()
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

        public string InsertBarangmasuk(aptbarangmasuk obj,List<aptbarangmasukdetail> lstobj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptbarangmasukRepository.Save(obj);
                    if (!string.IsNullOrEmpty(data.Item2))
                        return data.Item2;
                    string errResult = string.Empty;
                    foreach(aptbarangmasukdetail o in lstobj)
                    {
                        o.aptbarangmasukid = short.Parse( data.Item1.ToString());
                        errResult = uow.AptbarangmasukdetailRepository.Save(o);
                        if (!string.IsNullOrEmpty(errResult)) return errResult;
                    }

                    uow.Commit();
                    return data.Item2;
                }
            }
        }

        public string DeleteBarangmasuk(aptbarangmasuk obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptbarangmasukRepository.Delete(obj);
                    if (!string.IsNullOrEmpty(data)) return data;
                    uow.Commit();
                    return data;
                }
            }
        }

        public string DeleteBarangmasukDetail(aptbarangmasukdetail obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.AptbarangmasukdetailRepository.Delete(obj);
                    if (!string.IsNullOrEmpty(data)) return data;
                    uow.Commit();
                    return data;
                }
            }
        }


    }
}
