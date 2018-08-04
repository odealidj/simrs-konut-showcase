using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_aptbarangmasukdetail_aptbrggudetail
    {
        public short aptbarangmasukdetailid { get; set; }
        public short? aptbarangid { get; set; }
        public string aptbarangnm { get; set; }
        public DateTime? tglkadaluarsa { get; set; }
        public string skecil { get; set; }
        public short? isiskecil { get; set; }
        public string sbesar { get; set; }
        public short? isisbesar { get; set; }
        public decimal? hargasatuan { get; set; }
        public double? potonganpersen { get; set; }
        public decimal? jmlharga { get; set; }
        public decimal? hargaskecil { get; set; }
        public decimal? hargapph { get; set; }
        public decimal? harga35 { get; set; }
        public decimal? hargatoeslag { get; set; }
        public decimal? hargajual { get; set; }
        public short aptbrggudetailid { get; set; }
        public short? aptbrgguid { get; set; }
        public short aptbarangmasukid { get; set; }
    }



}
