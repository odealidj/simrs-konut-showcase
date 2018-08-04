using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface ITarifRepository : IBaseRepository<tarif>
    {
        //            SELECT* FROM v_tarif AS t
        //WHERE t.penjaminpasienid = 1
        //AND t.kelasid = 98
        //AND t.ruangrawatid = 5
        //AND t.jenistarifid = 01
        //AND t.daftartindakannm LIKE '%Anti%'

        Task<(IEnumerable<v_tarif>, string)> GetAllVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(short penjaminid, short kelasid, short ruangrawatid, short jenistarifid, string tindakan);
        Task<(IEnumerable<v_tarif>, string)> GetTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(short penjaminid, short kelasid, short ruangrawatid, short jenistarifid);
        (IEnumerable<v_tarif>, string) GetAllVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakan(short penjaminid, short kelasid, short ruangrawatid, short jenistarifid, string tindakan);
        (IEnumerable<v_tarif>, string) GetTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakan(short penjaminid, short kelasid, short ruangrawatid, short jenistarifid);

        (IEnumerable<v_tarif_withaout_jenistarif_penjaminid>, string) GetAllv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(short kelasid, short ruangrawatid, string tindakan);
        (IEnumerable<v_tarif_withaout_jenistarif_penjaminid>, string) GetAllv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(short ruangrawatid, string tindakan);

        (IEnumerable<v_tarif_withaout_jenistarif_penjaminid>, string) GetAllv_tarif_withaout_kelas_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(short ruangrawatid, string tindakan);

        bool Update(int daftartindakanid, short kelasid, decimal harga, decimal jasasarana, decimal jasapelayanan);

        bool Update(int daftartindakanid, decimal harga, decimal jasasarana, decimal jasapelayanan);

    }
}
