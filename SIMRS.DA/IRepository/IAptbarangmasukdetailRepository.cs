using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IAptbarangmasukdetailRepository : IBaseRepository<aptbarangmasukdetail>
    {
        Task<(IEnumerable<v_aptpembeliandetail>, string)> GetAll_v_aptpembeliandetailByAptbarangmasukIdAsync(short aptbarangmasukid);
        (IEnumerable<v_aptpembeliandetail>, string) GetAll_v_aptpembeliandetailByAptbarangmasukId(short aptbarangmasukid);

        (IEnumerable<v_aptpembeliandetail>, string) GetAll_v_aptpembeliandetailByAptbarangmasukId(short aptbarangmasukid,string filter);

        

        new string Save(aptbarangmasukdetail obj);

        new string Delete(aptbarangmasukdetail obj);
    }
}
