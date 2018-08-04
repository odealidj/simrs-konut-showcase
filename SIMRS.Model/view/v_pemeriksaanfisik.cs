using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_pemeriksaanfisik
    {
        public short pemeriksaanfisikid { get; set; }
        public DateTime? tglperiksafisik { get; set; }
        public short? registrasiruangrawatid { get; set; }
        public short perawatid { get; set; }
        public string perawatnm { get; set; }
        public short dokterid { get; set; }
        public string dokternm { get; set; }
        public string tensi { get; set; }
        public string suhu { get; set; }
        public string beratbadan { get; set; }
        public string nadi { get; set; }
        public string kesadaran { get; set; }
        public string tinggibadan { get; set; }
        public string lila { get; set; }
    }


}
