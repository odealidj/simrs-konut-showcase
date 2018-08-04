using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_aptstockkontrol
    {
        public short aptbarangid { get; set; }
        public string aptbarangnm { get; set; }
        public int stsisonline { get; set; }
        public bool? isonline { get; set; }
        public string tahunbulanexpire { get; set; }
        public string defenisisatuan { get; set; }
        public short? jmlstock { get; set; }
        public string satuankecil { get; set; }
        public decimal? hargaskecil { get; set; }
        public decimal? hargapph { get; set; }
        public decimal? harga35 { get; set; }
        public decimal? hargatoeslag { get; set; }
        public decimal? hargajual { get; set; }
    }


}
