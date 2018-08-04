using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMRS.Model;

namespace SIMRS.DA.IRepository
{
    public interface ILoginappRepository : IBaseRepository<loginapp>
    {
        loginapp getLoginappByUsernameAndPassword(string username, string password);
    }
}
