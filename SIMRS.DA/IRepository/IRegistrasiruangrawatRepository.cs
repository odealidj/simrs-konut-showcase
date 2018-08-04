using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IRegistrasiruangrawatRepository : IBaseRepository<registrasiruangrawat>
    {
        Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short? stsregistrasiid, string value);
        Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short? stsregistrasiid,short ruangrawatid,short stsmasukkeluarruangrawatid, string value);
        Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short? stsregistrasiid, short ruangrawatid, short stsmasukkeluarruangrawatid, string value, DateTime tglmasuk);

        Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short ruangrawatid, short stsmasukkeluarruangrawatid, string value, DateTime tglmasuk);
        Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaTglKeluarRuanganAsync(int pageIndex, int pageSize, short pelayananmedikid, short ruangrawatid, short stsmasukkeluarruangrawatid, string value, DateTime tglkeluarruangan);
        Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short ruangrawatid, short stsmasukkeluarruangrawatid, string value);

        Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndTglMasukAndFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short? stsregistrasiid, short ruangrawatid,DateTime tglmasuk, string value);
        Task<(IEnumerable<v_registrasiruangrawatrjrd>, string)> GetAllVregistrasiruangrawatrjrdByPageIndexAndFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short? stsregistrasiid, string value);
        Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAsync(int pageIndex, int pageSize, short pelayananmedikid, short? stsregistrasiid);

        Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllv_registrasiruangrawatByRegistrasiidAsync(short registrasiid);

        (IEnumerable<v_statuspenyakit>, string) GetAllv_statuspenyakitByNormAsync(string norm);

        (IEnumerable<v_registrasiruangrawat>, string) GetAllVregistrasiByPelayananmedikIdAndTglMasukAndStsmasukkeluarAndFilterByNocmNoregNama(short pelayananmedikid,  DateTime tglmasuk, short stsmasukkeluar, string value);

        bool UpdateStsMasukKeluarRuangRawat(short registrasiruangrawatid, short stsmasukkeluarruangrawatid,DateTime tglkeluarruangan, DateTime jamkeluarruangan);
        
        bool UpdateStsMasukKeluarRuangRawatByRegistrasiid(short registrasiid, short stsmasukkeluarruangrawatid);

 


    }
}
