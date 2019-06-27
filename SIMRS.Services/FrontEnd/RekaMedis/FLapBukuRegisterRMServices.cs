using SIMRS.Model;
using SIMRS.Services.FrontEnd.Registrasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.RekaMedis
{
    public class FLapBukuRegisterRMServices : FLapBukuRegisterServices
    {
        public IEnumerable<pelayananmedik> SelectAllPelayananmedik()
        {
            
                using (var service = new PelayananmedikServices())
                {
                    return service.SelectAll();
                }
           
        }
    }
}
