using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_pelunasan
    {
        public short registrasiid { get; set; }
        public DateTime? tglmasuk { get; set; }
        public DateTime? jammasuk { get; set; }
        public string noregistrasi { get; set; }
        public string nocm { get; set; }
        public DateTime? tglkeluar { get; set; }
        public DateTime? jamkeluar { get; set; }
        public string nama { get; set; }
        public string jknm { get; set; }
        public DateTime? tanggallahir { get; set; }
        public short? thn { get; set; }
        public short? bulan { get; set; }
        public short? hari { get; set; }
        public string umur { get; set; }
        public short? ruangrawatid { get; set; }
        public string ruangrawatnm { get; set; }
        public short? ruangrawatid2 { get; set; }
        public string ruangrawatnm2 { get; set; }
        public short? penjaminpasienid { get; set; }
        public string penjaminpasiennm { get; set; }
        public string prosedurmasukid { get; set; }
        public string prosedurmasuknm { get; set; }
        public short? pelayananmedikid { get; set; }
        public string pelayananmediknm { get; set; }
        public short registrasiruangrawatid { get; set; }
        public DateTime? tglmasukruangan { get; set; }
        public short? kelasid { get; set; }
        public string kelasnm { get; set; }
        public string kelasuraian { get; set; }
        public short? kamarid { get; set; }
        public string kamarnm { get; set; }
        public short? tempattidurid { get; set; }
        public string tempattidurnm { get; set; }
        public short? stsregistrasiid { get; set; }
        public string stsregistrasinm { get; set; }
        public short? stsmasukkeluarid { get; set; }
        public string stsmasukkeluarnm { get; set; }
        public short? stsmasukkeluarruangrawatid { get; set; }
        public string stsmasukkeluarruangrawatnm { get; set; }
        public int pelayananpasienid { get; set; }
        public DateTime? pelayananpasientgl { get; set; }
        public DateTime? pelayananpasienjam { get; set; }
        public short? registrasipenunjangid { get; set; }
        public short? dokterid { get; set; }
        public string dokternm { get; set; }
        public short? perawatid { get; set; }
        public string perawatnm { get; set; }
        public string jenistarifid { get; set; }
        public string jenistarifnm { get; set; }
        public int? tarifid { get; set; }
        public string daftartindakannm { get; set; }
        public decimal? biaya { get; set; }
        public short? jml { get; set; }
        public decimal? totalbiaya { get; set; }
        public string alamat { get; set; }
        public short strukpelayananid { get; set; }
        public decimal? grandtotalbiaya { get; set; }
        public decimal? grandtotalbayar { get; set; }
    }



}
