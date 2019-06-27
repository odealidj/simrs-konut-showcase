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
    public class LoginServices : IDisposable
    {
        //static string ErrResult;

        protected IDapperContext context;
        protected IUnitOfWork uow;

        public LoginServices()
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

        public (loginappdetail, loginmodulapp, string) GetLoginappdetailAndLoginmodulappByUsernamePasswordModulappkode(string username, string password, string modulappkode)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.LoginmodulappRepository.GetLoginappdetailAndLoginmodulappByUsernamePasswordModulappkode(username, password, modulappkode);
                }
            }

        }

        public async Task<(pelayananmedik, string)> GetAllPelayananmedikByModulappkodeAsync(string modulappkode)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PelayananmedikRepository.GetAllPelayananmedikByModulappkodeAsync(modulappkode);
                }
            }

        }


        public (pelayananmedik, string) GetAllPelayananmedikByModulappkode(string modulappkode)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.PelayananmedikRepository.GetAllPelayananmedikByModulappkode(modulappkode);
                }
            }

        }

        //public (loginmodulapp, string) getLoginmodulappByLoginappidAndModulappid(short loginappid, string modulappkode)
        //{
        //    ErrResult = null;

        //    loginmodulapp login = null;
        //    try
        //    {

        //        using (var scope = _container.BeginLifetimeScope())
        //        {
        //            //using (scope.Resolve<IDapperContext>())
        //            //{
        //            var result = scope.Resolve<ILoginmodulappRepository>().getLoginmodulappByLoginappidAndModulappid(loginappid, modulappkode);
        //            login = result.Item1;
        //            ErrResult = result.Item2;
        //            //}
        //        }
        //        //ErrResult = await Task.FromResult<string>(null);
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrResult = ex.Message + "\ngetLoginmodulappByLoginappidAndModulappid";
        //    }

        //    return (login, ErrResult);
        //}

        public (loginappdetail, string) Get(loginappdetail obj)
        {
            string errResult = null;
            loginappdetail login = null;
            try
            {
                using (context = new DapperContext())
                {
                    using (uow = new UnitOfWork(context))
                    {
                        login = uow.LoginappdetailRepository.Get(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                errResult = ex.Message + "\ngetLoginmodulappByLoginappid";
            }
            return (login, errResult);

        }
    }
}
