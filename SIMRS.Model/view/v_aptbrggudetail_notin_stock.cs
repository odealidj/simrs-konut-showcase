using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_aptbrggudetail_notin_stock
    {
        public string aptbarangnm { get; set; }
        public DateTime? tglkadaluarsa { get; set; }
        public short? aptpbfid { get; set; }
        public string defenisisatuan { get; set; }
        public short? jmlbrg { get; set; }
        public string satuan { get; set; }
        public decimal? hargaskecil { get; set; }
        public decimal? hargapph { get; set; }
        public decimal? harga35 { get; set; }
        public decimal? hargatoeslag { get; set; }
        public decimal? hargajual { get; set; }
        public short aptbrgguid { get; set; }
        public short aptbrggudetailid { get; set; }
        public bool isstock { get; set; }
    }


}
