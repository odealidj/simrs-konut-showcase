using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class pemeriksaanfisik
    {
        public short pemeriksaanfisikid { get; set; }
        public DateTime? tglperiksafisik { get; set; }
        public short? registrasiruangrawatid { get; set; }
        public short perawatid { get; set; }
        public short dokterid { get; set; }
        public string tensi { get; set; }
        public string suhu { get; set; }
        public string beratbadan { get; set; }
        public string nadi { get; set; }
        public string respirasi { get; set; }
        public string kesadaran { get; set; }
        public string kepala { get; set; }
        public string leher { get; set; }
        public string dada { get; set; }
        public string perut { get; set; }
        public string punggung { get; set; }
        public string daerahgenetalis { get; set; }
        public string extremitas_atas { get; set; }
        public string extremitas_bwh { get; set; }
        public string terapi { get; set; }
        public string tinggibadan { get; set; }
        public string lila { get; set; }
    }


}
