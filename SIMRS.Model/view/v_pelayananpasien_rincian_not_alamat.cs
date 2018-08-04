using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_pelayananpasien_rincian_not_alamat
    {
        public short registrasiid { get; set; }
        public int pelayananpasienid { get; set; }
        public DateTime? pelayananpasientgl { get; set; }
        public int? tarifid { get; set; }
        public string daftartindakannm { get; set; }
        public decimal? biaya { get; set; }
        public short? jml { get; set; }
        public decimal? totalbiaya { get; set; }
        public string dokternm { get; set; }
        public string perawatnm { get; set; }
        public short? ruangrawatid { get; set; }
        public string ruangrawatnm { get; set; }
        public short? ruangrawatid2 { get; set; }
        public string ruangrawatnm2 { get; set; }
        public short? pelayananmedikid { get; set; }
        public string pelayananmediknm { get; set; }
        public short? kelasid { get; set; }
        public string kelasuraian { get; set; }

        public short? tempattidurid { get; set; }

    }

}
