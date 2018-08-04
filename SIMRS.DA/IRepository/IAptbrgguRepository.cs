using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{

    public interface IAptbrgguRepository : IBaseRepository<aptbrggu>
    {
        Task<(IEnumerable<aptbrggu>, string)> GetAllAsync(string tahun, string bulan);

        Task<(IEnumerable<v_aptbarangmasuk_pbf_aptbrggu>, string)> GetAll_v_aptbarangmasuk_pbf_aptbrggu(short aptbrgguid);
        Task<(IEnumerable<v_aptbarangmasukdetail_aptbrggudetail>, string)> GetAll_v_aptbarangmasukdetail_aptbrggudetail(short aptbrgguid,short aptbarangmasukid);
        Task<(IEnumerable<v_aptbarangmasukdetail_aptbrggudetail>, string)> GetAll_v_aptbarangmasukdetail_aptbrggudetail(short aptbarangmasukdetailid);

        Task<(v_aptgenerateharga, string)> GetAll_v_aptgenerateharga(short aptbarangmasukdetailid);

        new(int, string) Save(aptbrggu obj);

        new string Delete(aptbrggu obj);

        string SaveAptbrggudetail(short aptbrggudetailid, short aptbrgguid, short aptbarangmasukid);
    }
}
