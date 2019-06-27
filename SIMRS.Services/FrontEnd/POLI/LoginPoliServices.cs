using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.POLI
{
    public class LoginPoliServices : LoginServices
    {
        //protected IDapperContext context;
        //protected IUnitOfWork uow;

        public LoginPoliServices()
        {
            //context = new DapperContext();
            //uow = new UnitOfWork(context);
        }

        //public void Dispose()
        //{
        //    if (uow != null)
        //    {
        //        try
        //        {
        //        }
        //        finally
        //        {
        //            uow.Dispose();
        //        }
        //    }
        //    if (context != null)
        //    {
        //        try
        //        {
        //        }
        //        finally
        //        {
        //            context.Dispose();
        //        }
        //    }

        //    GC.SuppressFinalize(this);
        //}

        public async Task<(IEnumerable<ruangrawat>, string)>SelectRuangRawatByPelayananmedikIdAsync(short pelayananmedikid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RuangrawatRepository.GetAllByPelayananmedikIdAsync(pelayananmedikid);
                }
            }

        }
    }
}
