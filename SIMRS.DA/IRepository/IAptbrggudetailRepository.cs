using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAptbrggudetailRepository: IBaseRepository<aptbrggudetail>
    {
        new(int, string) Save(aptbrggudetail obj);

        (int, string) Save(short aptbrggudetailid, short aptbrgguid, short aptbarangmasukid);

        new string Delete(aptbrggudetail obj);

        Task<(IEnumerable<v_aptbrggudetail>, string)> GetAllv_aptbrggudetailByAptbrgguidAsync();
        Task<(IEnumerable<v_aptbrggudetail>, string)> GetAllv_aptbrggudetailByAptbrgguidAsync(string tahun, string bulan);
        Task<(IEnumerable<v_aptbrggudetail>, string)> GetAllv_aptbrggudetailByAptbrgguidAsync(string namabarang);

        Task<(IEnumerable<v_aptbrggudetail>, string)> GetAllv_aptbrggudetailByAptbrgguidAsync(short aptbrgguid);
        Task<(IEnumerable<v_aptbrggudetail>, string)> GetAllv_aptbrggudetailByAptbrgguidAsync(short aptbrgguid, string namabarang);

        string UpdateTarif(aptbrggudetail obj);
    }
}
