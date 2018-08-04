using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAnamnesapasienRepository : IBaseRepository<anamnesapasien>
    {
        Task<(IEnumerable<v_anamnesapasien>, string)> GetAllv_anamnesapasienByRegistrasiruangrawatidAsync(short registrasiruangrawatid);
        Task<(IEnumerable<v_anamnesapasien>, string)> GetAllv_anamnesapasienByRegistrasiruangrawatidAsync(short registrasiruangrawatid, DateTime tglperiksa);


    }
}
