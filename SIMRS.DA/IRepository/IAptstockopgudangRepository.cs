using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAptstockopgudangRepository : IBaseRepository<aptstockopgudang>
    {
        Task<(IEnumerable<v_aptstockopgudang>, string)> GetAll_v_aptstockopgudangByYearAndMonthAsync(short year, short month);
        (IEnumerable<v_aptstockopgudang>, string) GetAll_v_aptstockopgudangByYearAndMonth(short year, short month);

        (IEnumerable<v_aptstockopgudang>, string) GetAll_v_aptstockopgudangByYearAndMonthAndKet(string value);

        (IEnumerable<v_aptstockopgudang>, string) GetAll_v_aptstockopgudang();
    }
}
