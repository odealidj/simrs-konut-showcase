using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IRuangrawatRepository : IBaseRepository<ruangrawat>
    {
        Task<(IEnumerable<ruangrawat>, string)> GetAllByPelayananmedikIdAsync(short pelayananmedikid);
        (IEnumerable<vruangrawat_kelasruangrawatid_kamarid_tempattidurid>, string) GetAllvruangrawat_kelasruangrawatid_kamarid_tempattidurid(short pelayananmedikid);

    }
}
