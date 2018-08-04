using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAptstockopRepository : IBaseRepository<aptstockop>
    {
        Task<(IEnumerable<v_aptbrggudetail_notin_stock>, string)> GetAll_v_aptbrggudetail_notin_stock();

        new(int, string) Save(aptstockop obj);

        new string Delete(aptstockop obj);
    }
}
