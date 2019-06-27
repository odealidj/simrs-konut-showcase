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
    public class RuangrawatServices : IDisposable
    {
        #region constructor

        protected IDapperContext context;
        protected IUnitOfWork uow;

        public RuangrawatServices()
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

        public (IEnumerable<vruangrawat_kelasruangrawatid_kamarid_tempattidurid>, string) SelectAllvruangrawat_kelasruangrawatid_kamarid_tempattidurid(short pelayananmedikid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.RuangrawatRepository.GetAllvruangrawat_kelasruangrawatid_kamarid_tempattidurid(pelayananmedikid);
                }
            }
        }


    }
}
