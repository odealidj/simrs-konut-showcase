using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IJenistarifRepository : IBaseRepository<jenistarif>
    {
        Task<(IEnumerable<v_jenistarifpenjamin>, string)> GetAllVjenistarifpenjaminByPenjaminIdAsync(short penjaminid);
        (IEnumerable<v_jenistarifpenjamin>, string) GetAllVjenistarifpenjaminByPenjaminId(short penjaminid);
        (jenistarif, string) GetJenistarifByRuangrawatIdAndPenjaminId(short ruangrawatid, short penjaminid);
    }
}
