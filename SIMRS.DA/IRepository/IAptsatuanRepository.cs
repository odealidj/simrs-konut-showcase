using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAptsatuanRepository : IBaseRepository<aptsatuan>
    {
        Task<(IEnumerable<aptsatuan>, string)> GetAllAsync(string filtered);
        Task<(IEnumerable<aptsatuan>, string)> GetAllNotInKodeAsync(string aptsatuankode);

        (int, string) Save(aptsatuan obj, string newaptsatuankode);

        new string Delete(aptsatuan obj);
    }
}
