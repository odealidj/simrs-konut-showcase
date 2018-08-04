using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IIcdxpuskesmasRepository : IBaseRepository<icdxpuskesmas>
    {
        Task<(IEnumerable<icdxpuskesmas>, string)> GetAllIcdxpuskesmasBynameAsync(string icdxname);
        (IEnumerable<icdxpuskesmas>, string) GetAllIcdxpuskesmasByname(string icdxname);
        Task<(IEnumerable<vicdxpuskesmas>, string)> GetAllVicdxpuskesmasAsync();
        Task<(IEnumerable<vicdxpuskesmas>, string)> GetAllVicdxpuskesmasByKodenamaAsync(string kodenama);

    }
}
