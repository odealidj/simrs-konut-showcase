using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_aptgudangdetail
    {
        public byte aptpbfid { get; set; }
        public string aptpbfnm { get; set; }
        public short aptbarangid { get; set; }
        public string aptbarangnm { get; set; }
        public short aptbarangmasukid { get; set; }
        public DateTime? tglbeli { get; set; }
        public string faktur { get; set; }
        public byte? potonganpersen { get; set; }
        public short aptbarangmasukdetailid { get; set; }
        public string kodebarangpbf { get; set; }
        public short? jmlsatuanbesar { get; set; }
        public string satuanbesarkode { get; set; }
        public short? isisatuankecil { get; set; }
        public string satuankecilkode { get; set; }
        public DateTime? tglkadaluarsa { get; set; }
        public decimal? hargapersatuanbesar { get; set; }
        public decimal? TotalBeli { get; set; }
        public decimal? hargasatuan { get; set; }
        public decimal? hargappn { get; set; }
        public decimal? hargatigalima { get; set; }
        public decimal? hargatoeslag { get; set; }
        public decimal? hargajual { get; set; }
    }

}
