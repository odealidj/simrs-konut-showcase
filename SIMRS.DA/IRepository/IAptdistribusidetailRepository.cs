using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAptdistribusidetailRepository : IBaseRepository<aptdistribusidetail>
    {
        (IEnumerable<v_aptdistribusidetail>, string) GetAllv_aptdistribusidetailByAptdistribusiId(short aptdistribusiid);

        (IEnumerable<v_aptdistribusidetail>, string) GetAllv_aptdistribusidetailByAptdistribusiId(short aptdistribusiid, string filter);
    }
}
