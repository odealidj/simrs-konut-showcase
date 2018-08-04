using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface ITempattidurRepository : IBaseRepository<tempattidur>
    {
        Task<(IEnumerable<v_jmltempattidurbasekelasrawatinap>, string)> GetVjmltempattidurbasekelasrawatinapAsync();
        Task<(IEnumerable<v_listtempattidurrawatinap>, string)> GetVlisttempattidurrawatinapAsync();
        Task<(IEnumerable<v_listtempattidurrawatinap>, string)> GetVlisttempattidurrawatinapByKelasidAsync(short kelasid);

        int Updatetempattidurisi(short tempattidurid, short tempattidurisi);

        int Updatetempattidurisi(IList<short> tempattidurid, short tempattidurisi);


    }
}
