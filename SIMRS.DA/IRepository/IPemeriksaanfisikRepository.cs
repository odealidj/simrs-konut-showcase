using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IPemeriksaanfisikRepository : IBaseRepository<pemeriksaanfisik>
    {
        Task<(IEnumerable<pemeriksaanfisik>, string)> GetAllAsync(short pemeriksaanfisikid);
        Task<(IEnumerable<v_pemeriksaanfisik>, string)> GetAllv_pemeriksaanfisikAsync(short pemeriksaanfisikid);
        Task<(IEnumerable<v_pemeriksaanfisik>, string)> GetAllv_pemeriksaanfisikByregistrasiruangrawatidAsync(short registrasiruangrawatid,DateTime tglperiksa);

    }
}
