using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAptdepoRepository : IBaseRepository<aptdepo>
    {
        Task<(IEnumerable<aptdepo>, string)> GetAllAsync(string filtered);

        new(int, string) Save(aptdepo obj);

        new string Delete(aptdepo obj);
    }
}
