using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.RawatInap
{
    public class RawatInapServices : IDisposable
    {
        //static string ErrResult;

        protected IDapperContext context;
        protected IUnitOfWork uow;

        #region Constructor
        public RawatInapServices()
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

        public (string, string) UpdateCaraPulang(short registrasiid, short stsmasukkeluarruangrawatid, byte carapulangid)
        {
            var errresult = (string.Empty, string.Empty);
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {

                    uow.BeginTransaction();
                    var resultupdateruangrawat = uow.RegistrasiruangrawatRepository.UpdateStsMasukKeluarRuangRawatByRegistrasiid(registrasiid, stsmasukkeluarruangrawatid);
                    if (resultupdateruangrawat == true)
                    {

                        var resultregistrasi =  uow.RegistrasiRepository.UpdateCaraPulang(registrasiid, carapulangid);
                        
                        if (resultregistrasi != -99)
                        {

                        }
                        else
                        {
                            errresult = (string.Empty, "Proses update cara pulang tidak valid");
                            return errresult;

                        }
                    }
                    else
                    {

                        errresult = ("Proses update sts masuk registrasiruangrawat tidak valid", "Proses update cara pulang tidak valid");
                        return errresult;
                    }
                    uow.Commit();

                    return errresult;
                }
            }
        }

    }
}
