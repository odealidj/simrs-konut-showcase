using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository.IExpand
{
    public interface ISuratRujukanBPJSRepository 
    {
        Task<(IEnumerable<puskesmas>, IEnumerable<ruangrawatrujukan>, IEnumerable<vicdxpuskesmas>, string)> GetAllPuskesmasByPerujukIdAndGetAllRuangRawatRujukanAndVicdxpuskesmasAsync(short? puskesmasperujukid);
    }
}
