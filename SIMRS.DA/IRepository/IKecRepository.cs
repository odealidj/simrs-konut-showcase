using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IKecRepository : IBaseRepository<kec>
    {
        Task<(IEnumerable<kec>, string)> GetAllKecByKotakabIdAsync(short? kotakabid);
    }
}
