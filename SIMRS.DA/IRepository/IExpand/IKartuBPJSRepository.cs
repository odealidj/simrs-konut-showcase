using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository.IExpand
{
    public interface IKartuBPJSRepository
    {
        Task<(IEnumerable<kelas>, IEnumerable<jk>, IEnumerable<kec>, string)> GetAllKelasBPJSAndJKAndKecKartuBPJSAsync(short? kotakabid);
    }
}
