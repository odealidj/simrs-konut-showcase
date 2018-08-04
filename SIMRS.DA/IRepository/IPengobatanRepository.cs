using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IPengobatanRepository : IBaseRepository<pengobatan>
    {
        Task<(IEnumerable<v_pengobatan>, string)> GetAllv_pengobatanByRegistrasiruangrawatidAsync(short registrasiruangrawatid);

        (IEnumerable<pengobatanaturanpakai>, string) GetAllPengobatanaturanpakai();
        (IEnumerable<pengobatannama>, string) GetAllPengobatannama();
        (IEnumerable<pengobatansatuan>, string) GetAllPengobatansatuan();
        (IEnumerable<pengobatanukuran>, string) GetAllPengobatanukuran();
    }
}
