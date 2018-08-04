using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IKelasRepository : IBaseRepository<kelas>
    {
        Task<(IEnumerable<kelas>, string)> GetAllKelasBPJSAsync();
    }
}
