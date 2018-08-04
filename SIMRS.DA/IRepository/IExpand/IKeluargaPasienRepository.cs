using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository.IExpand
{
    public interface IKeluargaPasienRepository
    {
        Task<(IEnumerable<hubkeluarga>, IEnumerable<identitasdiri>, IEnumerable<jk>, IEnumerable<kec>, string)> GetAllHubkeluargaAndIdentitasdiriAndJKAndKecByKotakabIdKeluargaPasienAsync (short? kotakabid);
    }
}
