using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAptbarangRepository : IBaseRepository<aptbarang>
    {
        Task<(IEnumerable<v_aptbarang>, string)> GetAll_v_aptbarang_ByPageIndex(int pageIndex, int pageSize);

        Task<(IEnumerable<v_aptbarang>, string)> GetAll_v_aptbarang_ByPageIndex(int pageIndex, int pageSize, string filtered);
        Task<(IEnumerable<v_aptbarang>, string)> GetAll_v_aptbarang_ByPageIndexAndAptdef1id(int pageIndex, int pageSize, string aptdef1id);

        new(int, string) Save(aptbarang obj);

        new string Delete(aptbarang obj);

    }
}
