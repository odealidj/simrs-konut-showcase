using SIMRS.DA;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.Registrasi
{
    public class ListRegistrasiRIServices : ListRegistrasiServices
    {
        public ListRegistrasiRIServices()
        {

        }

        public async Task<(IEnumerable<v_jmltempattidurbasekelasrawatinap>, string)> SelectVjmltempattidurbasekelasrawatinapAsync()
        {
            try
            {
                using (context = new DapperContext())
                {
                    using (uow = new UnitOfWork(context))
                    {
                        return await uow.TempattidurRepository.GetVjmltempattidurbasekelasrawatinapAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<(IEnumerable<v_listtempattidurrawatinap>, string)> SelectVlisttempattidurrawatinapByKelasidAsync(short kelasid)
        {
            try
            {
                using (context = new DapperContext())
                {
                    using (uow = new UnitOfWork(context))
                    {
                        return await uow.TempattidurRepository.GetVlisttempattidurrawatinapByKelasidAsync(kelasid); 
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
