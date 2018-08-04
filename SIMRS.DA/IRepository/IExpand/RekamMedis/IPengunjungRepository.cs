using SIMRS.Model.customobject.rekammedis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository.IExpand.RekamMedis
{
    public interface IPengunjungRepository
    {
        Task<(IEnumerable<copengunjung>, string)> getAllPengunjung(int tahun, int bulan);
    }
}
