using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAptstockopgudangdetailRepository: IBaseRepository<aptstockopgudangdetail>
    {
        (IEnumerable<v_aptstockopgudangdetail>, string) GetAll_v_aptstockopgudangdetailByAptstockopgudangId(short AptstockopgudangId);

        (IEnumerable<v_aptstockopgudangdetail>, string) GetAll_v_aptstockopgudangdetailByAptstockopgudangId(short AptstockopgudangId, string filter);

    }
}
