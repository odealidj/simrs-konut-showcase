using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository.IExpand
{
    public interface IRLRepository
    {
        Task<(IEnumerable<v_RL_51_Pengunjung>, string)> GetAllv_RL_51_PengunjungByThnAndBlnAsync(int thn, int bln);
        Task<(IEnumerable<v_RL_54>, string)> GetAllv_RL_54ByThnAndBlnAsync(int thn, int bln);
    }
}
