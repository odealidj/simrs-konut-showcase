using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAptdistribusiRepository : IBaseRepository<aptdistribusi>
    {
        (IEnumerable<v_aptdistribusi>, string) GetAllv_aptdistribusi();
        (IEnumerable<v_aptdistribusi>, string) GetAllv_aptdistribusi(string year, string month);

        (IEnumerable<v_aptdistribusi>, string) GetAllv_aptdistribusi(string depo);

        
    }
}
