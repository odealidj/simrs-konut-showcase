using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IPerawatRepository : IBaseRepository<perawat>
    {
        Task<(IEnumerable<v_perawat>, string)> GetAllVperawatAsync();
        Task<(IEnumerable<v_perawat>, string)> GetAllVperawatAsync(short ruangrawatid);
    }
}
