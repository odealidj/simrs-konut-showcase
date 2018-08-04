using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IRegistrasiRepository : IBaseRepository<registrasi>
    {
        new (short, string, string) Save(registrasi obj);
        Task<IEnumerable<v_registrasi>> GetAllv_registrasiByPageIndexAndNoCM(int pageIndex, int pageSize,string nocm);
        Task<IEnumerable<v_registrasi>> GetAllv_registrasiByPageIndexAndNoCM(int pageIndex, int pageSize, EnuminstalasiPelayanan instalasipelayanan,string nocm);
        Task<IEnumerable<v_registrasi>> GetAllv_registrasiByPageIndexAndNoCMAndNoregistrasi(int pageIndex, int pageSize, string nocm,string noregistrasi);
        Task<IEnumerable<v_registrasi>> GetAllv_registrasiByPageIndexAndNoregistrasi(int pageIndex, int pageSize, string nocm, string noregistrasi);
        Task<(IEnumerable<v_registrasi>,string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAsync(int pageIndex, int pageSize, short pelayananmedikid);
        Task<(IEnumerable<v_registrasi>,string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, string value);

        Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize,DateTime tglmasuk);
        Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, DateTime tglmasuk,int? stsmasukkeluar);
        Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, DateTime tglmasuk,string value);
        Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, DateTime tglmasuk, string value,int?stsmasukkeluar);
        Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, string value);
        Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, string value, int? stsmasukkeluar);
        Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize);
        Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, int? stsmasukkeluar);


        stspasienbaru GetStspasienbaruByRegistrasiId(short registrasiid);

        //kasir
        int UpdateStsmasukkeluaraAndTglKeluar(short registrasiid, short stsmasukkeluarid,DateTime tglkeluar, DateTime jamkeluar);

        int UpdateCaraPulang(short registrasiid, byte carapulangid);


    }
}
