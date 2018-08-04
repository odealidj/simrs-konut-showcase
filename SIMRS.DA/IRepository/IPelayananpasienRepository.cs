using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IPelayananpasienRepository : IBaseRepository<pelayananpasien>
    {
        Task<(IEnumerable<v_pelayananpasien>, string)> GetAllVpelayananpasienByRegistrasiIdAsync(short registrasiid);
        
        int SaveKarcis(v_pelayananpasienkarcis vpelayananpasienkarcis);

        Task<(IEnumerable<v_tindakanpoli>, string)> GetAllVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(short registrasiid, short ruangrawatid);

        Task<(IEnumerable<v_tindakanpoli>, string)> GetAllVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(short registrasiid, short ruangrawatid, DateTime tgltindakan);

        Task<(IEnumerable<v_tindakanpenunjang>, string)> GetAllVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAsync(short registrasiid, short ruangrawatid, short ruangrawatpenunjangid);

        Task<(IEnumerable<v_tindakanpenunjang>, string)> GetAllVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAsync(short registrasiid, short ruangrawatid, short ruangrawatpenunjangid, DateTime tgltindakan);

        //modul kasir

        Task<(IEnumerable<v_pelayananpasien_distinct_from_not_alamat>, string)> Get50v_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(int pageIndex, int pageSize,short stsmasukkeluarid);
        
        Task<(IEnumerable<v_pelayananpasien_distinct_from_not_alamat>, string)> GetAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(int pageIndex, int pageSize, short stsmasukkeluarid, string filter);

        Task<(IEnumerable<v_pelayananpasien_distinct_from_not_alamat>, string)> GetAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAndTglMasukAsync(int pageIndex, int pageSize, DateTime tglmasuk);

        Task<(IEnumerable<v_pelayananpasien_distinct_from_not_alamat>, string)> GetAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAndTglKeluarAsync(int pageIndex, int pageSize, DateTime tglkeluar);

        Task<(IEnumerable<v_pelayananpasien_ruangperawatan_from_not_alamat>, string)> GetAllv_pelayananpasien_ruangperawatan_from_not_alamatByRegistrasiIdAsync(int registrasiid);
        Task<(IEnumerable<v_pelayananpasien_rincian_not_alamat>, string)> GetAllv_pelayananpasien_rincian_not_alamatByRegistrasiIdAsync(int registrasiid);
        (IEnumerable<v_pelayananpasien_rincian_not_alamat>, string) GetAllv_pelayananpasien_rincian_not_alamatByRegistrasiId(int registrasiid);


    }
}
