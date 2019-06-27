using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.Registrasi
{
    public class FLapBukuRegisterServices : IDisposable
    {
        #region constructor

        protected IDapperContext context;
        protected IUnitOfWork uow;

        public FLapBukuRegisterServices()
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

        public (IEnumerable<v_registrasiruangrawat>, string) SelectAllVregistrasiByPelayananmedikIdAndTglMasukAndStsmasukkeluarAndFilterByNocmNoregNama(short pelayananmedikid, DateTime tglmasuk, short stsmasukkeluar, string value)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.RegistrasiruangrawatRepository.GetAllVregistrasiByPelayananmedikIdAndTglMasukAndStsmasukkeluarAndFilterByNocmNoregNama(pelayananmedikid, tglmasuk, stsmasukkeluar, value);
                }
            }
        }


    }
}
