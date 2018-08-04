using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IRegistrasipenunjangRepository : IBaseRepository<registrasipenunjang>
    {
        Task<(IEnumerable<v_distinctcaripasienpenunjang_not_in_registrasipenunjang>, string)> GetAllVdistinctcaripasienpenunjangNotInRegistrasipenunjangByPageIndexAndStsmasukkeluarIdAsync(int pageIndex, int pageSize, short stsmasukkeluarid);
        Task<(IEnumerable<v_distinctcaripasienpenunjang_not_in_registrasipenunjang>, string)> GetAllVdistinctcaripasienpenunjangNotInRegistrasipenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(int pageIndex, int pageSize,short stsmasukkeluarid, string value);
        Task<(IEnumerable<v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang>, string)> GetAllVruangrawatcaripasienpenunjangNotInRegistrasipenunjangByRegistrasiIdAsync(short registrasiid, short pelayananmedikpenunjangid);

        Task<(IEnumerable<v_registrasiruangrawat_notin_registrasipenunjang>, string)> GetDistinctVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync(int pageIndex, int pageSize, short pelayananmedikpenunjangid, short stsmasukkeluarid, string value);
        Task<(IEnumerable<v_registrasiruangrawat_notin_registrasipenunjang>, string)> GetAllVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync(short registrasiid, short pelayananmedikpenunjangid);

        Task<(IEnumerable<v_distinctpasienpenunjang>, string)> GetAllVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(int pageIndex, int pageSize, short pelayananmedikid, short stsmasukkeluarid, string value);
        Task<(IEnumerable<v_distinctpasienpenunjang>, string)> GetAllVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(int pageIndex, int pageSize, short pelayananmedikid, short stsmasukkeluarid, DateTime tglmasuk);
        Task<(IEnumerable<v_registrasiruangrawat_penunjang>, string)> GetAllVregistrasiruangrawatpenunjangByRegistrasiIdAsync(short registrasiid, short pelayananmedikid);
    }


}
