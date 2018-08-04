using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IPelayananpasienpelunasanRepository: IBaseRepository<pelayananpasienpelunasan>
    {
        Task<(IEnumerable<v_registrasi_transaksi>, string)> GetAllVregistrasitransaksiByPageIndexAndFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, string value);

        int Save(IList<pelayananpasienpelunasan> obj, short strukpelayananid);
       
    }
}
