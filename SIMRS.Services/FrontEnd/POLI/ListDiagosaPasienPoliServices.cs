using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.POLI
{
  
    public class ListDiagosaPasienPoliServices : FListDiagnosaPasienService
    {
        public async Task<(IEnumerable<v_icdxpasienpoli>, string)> SelectVicdxpasienpoliAsync(short registrasiruangrawatid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.IcdxpasienRepository.GetAllVicdxpasienpoliAsync(registrasiruangrawatid);
                }
            }
        }

    }
}
