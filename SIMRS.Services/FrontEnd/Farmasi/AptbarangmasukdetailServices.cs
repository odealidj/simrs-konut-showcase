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
    public class AptbarangmasukdetailServices : IDisposable
    {
        #region constructor
        protected IDapperContext context;
        protected IUnitOfWork uow;

        public AptbarangmasukdetailServices()
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

        public async Task<(IEnumerable<v_aptpembeliandetail>, string)> SelectAll_v_aptpembeliandetailByAptbarangmasukIdAsync(short aptbarangmasukid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.AptbarangmasukdetailRepository.GetAll_v_aptpembeliandetailByAptbarangmasukIdAsync(aptbarangmasukid);
                }
            }
        }

        public (IEnumerable<v_aptpembeliandetail>, string) SelectAll_v_aptpembeliandetailByAptbarangmasukId(short aptbarangmasukid, string filter)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    if (string.IsNullOrEmpty(filter))
                        return uow.AptbarangmasukdetailRepository.GetAll_v_aptpembeliandetailByAptbarangmasukId(aptbarangmasukid);
                    else
                        return uow.AptbarangmasukdetailRepository.GetAll_v_aptpembeliandetailByAptbarangmasukId(aptbarangmasukid, filter);
                }
            }
        }
    }
}
