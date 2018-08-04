using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IPuskesmasRepository : IBaseRepository<puskesmas>
    {
        IEnumerable<puskesmas> GetAllPuskesmasByPerujukId(short perujukid);
        Task<(IEnumerable<puskesmas>, string)> GetAllPuskesmasByPerujukIdAsync(short perujukid);

    }
}
