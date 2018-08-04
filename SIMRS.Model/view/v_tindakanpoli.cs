using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_tindakanpoli
    {
        public short registrasiid { get; set; }
        public short registrasiruangrawatid { get; set; }
        public int pelayananpasienid { get; set; }
        public DateTime? pelayananpasientgl { get; set; }
        public DateTime? pelayananpasienjam { get; set; }
        public int daftartindakanid { get; set; }
        public string daftartindakannm { get; set; }
        public int tarifid { get; set; }
        public decimal? biaya { get; set; }
        public short? jml { get; set; }
        public decimal? totalbiaya { get; set; }
        public short? ruangrawatid { get; set; }
        public short? dokterid { get; set; }
        public string dokternm { get; set; }
        public short? perawatid { get; set; }
        public string perawatnm { get; set; }
    }


}
