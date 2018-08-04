using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IRtRepository : IBaseRepository<rt>
    {
        Task<(IEnumerable<rt>, string)> GetAllRtByRwIdAsync(short? rwid);
        Task<(IEnumerable<vrtrw>, string)> GetAllVrtrwByKeldesaidAsync(short? keldesaid);
        Task<(IEnumerable<vrtrw>, string)> GetAllVrtrwByKeldesaidAndRtrwNameAsync(short? keldesaid,string rtrwname);
    }
}
