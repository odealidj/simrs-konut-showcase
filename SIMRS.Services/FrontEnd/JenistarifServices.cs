using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd
{
    public class JenistarifServices : IDisposable
    {

        #region constructor

        protected IDapperContext context;
        protected IUnitOfWork uow;

        public JenistarifServices()
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

        public (jenistarif, string) FirstOrDefaultJenistarifByRuangrawatIdAndPenjaminId(short ruangrawatid, short penjaminid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.JenistarifRepository.GetJenistarifByRuangrawatIdAndPenjaminId(ruangrawatid, penjaminid);
                }
            }
        }
    }
}
