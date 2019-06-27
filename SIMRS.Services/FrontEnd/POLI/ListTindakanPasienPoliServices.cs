using SIMRS.DA;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.POLI
{
    public class ListTindakanPasienPoliServices : ListTindakanPasienServices
    {


        public async Task<(IEnumerable<v_tindakanpoli>, string)> SelectVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(short registrasiid, short ruangrawatid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PelayananpasienRepository.GetAllVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(registrasiid, ruangrawatid);
                }
            }
        }

        public async Task<(IEnumerable<v_tindakanpoli>, string)> SelectVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(short registrasiid, short ruangrawatid, DateTime tgltindakan)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PelayananpasienRepository.GetAllVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(registrasiid, ruangrawatid,tgltindakan);
                }
            }
        }

    }
}
