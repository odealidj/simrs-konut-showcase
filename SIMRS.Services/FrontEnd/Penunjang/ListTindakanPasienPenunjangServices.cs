using SIMRS.DA;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.Penunjang
{
    public class ListTindakanPasienPenunjangServices : ListTindakanPasienServices
    {
        public async Task<(IEnumerable<v_tindakanpenunjang>, string)> SelectVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAndRuangrawatpenunjangIdAsync(short registrasiid, short ruangrawatid,short ruangrawatpenunjangid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PelayananpasienRepository.GetAllVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAsync(registrasiid, ruangrawatid, ruangrawatpenunjangid);
                }
            }
        }

        public async Task<(IEnumerable<v_tindakanpenunjang>, string)> SelectVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAndRuangrawatpenunjangIdAsync(short registrasiid, short ruangrawatid,short ruangrawatpenunjangid, DateTime tgltindakan)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PelayananpasienRepository.GetAllVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAsync(registrasiid, ruangrawatid, ruangrawatpenunjangid, tgltindakan);
                }
            }
        }
    }
}
