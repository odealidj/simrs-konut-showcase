using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IIcdxpasienRepository : IBaseRepository<icdxpasien>
    {
        Task<(IEnumerable<v_icdxpasienpoli>, string)> GetAllVicdxpasienpoliAsync(short registrasiruangrawatid);
    }
}
