using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IRuangrawatrujukanRepository : IBaseRepository<ruangrawatrujukan>
    {
        Task<(IEnumerable<ruangrawatrujukan>, string)> GetAllRuangRawatRujukanByNameAsync(string namaruangrawat);
        (pelayananmedik, string) GetPelayananmedikByRuangrawatrujukanId(short ruangrawatid);
        Task<(pelayananmedik, string)> GetPelayananmedikByRuangrawatrujukanIdAsync(short ruangrawatid);

        new (IEnumerable<ruangrawatrujukan>, string) GetAll();
    }
}
