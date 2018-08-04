using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAptstockopdetaildRepository : IBaseRepository<aptstockopdetaild>
    {
        Task<(IEnumerable<v_aptstockkontrol>, string)> GetAll_v_aptstockkontrol();
        new(int, string) Save(aptstockopdetaild obj);

        new string Delete(aptstockopdetaild obj);
    }
}
