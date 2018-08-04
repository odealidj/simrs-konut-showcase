using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface ISuratrujukanpuskesmasRepository : IBaseRepository<suratrujukanpuskesmas>
    {
        IEnumerable<suratrujukanpuskesmas> GetAllSuratRujukanPuskesmasByPerujukId(short perujukid);
        Task<(IEnumerable<suratrujukanpuskesmas>, string)> GetAllSuratRujukanPuskesmasByPerujukIdAsync(short perujukid);
    }
}
