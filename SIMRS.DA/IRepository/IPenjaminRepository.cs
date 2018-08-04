using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IPenjaminRepository : IBaseRepository<penjaminpasien>
    {
        (penjaminpasien, string) GetPenjaminByNoRM(string NoRM);
        Task<(penjaminpasien, string)> GetPenjaminByNoRMAsync(string NoRM);

    }
}
