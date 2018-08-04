using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IDapperContext : IDisposable
    {
        IDbConnection db { get; }
        IDbConnection dbAsync { get; }
        int GetLastId();
    }
}
