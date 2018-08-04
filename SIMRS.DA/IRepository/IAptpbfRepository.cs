using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAptpbfRepository : IBaseRepository<aptpbf>
    {
        new(int, string) Save(aptpbf obj);

        new string Delete(aptpbf obj);
    }
}
