using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_aptstockopgudangdetail
    {
        public short aptbarangid { get; set; }
        public string aptdef1id { get; set; }
        public string aptbarangnm { get; set; }
        public byte aptpbfid { get; set; }
        public string aptpbfnm { get; set; }
        public short aptdef1satuanid { get; set; }
        public string satuankecilkode { get; set; }
        public byte? isisatuankecil { get; set; }
        public string satuanbesarkode { get; set; }
        public string aptdef1singkatan { get; set; }
        public short aptbarangmasukdetailid { get; set; }
        public byte? jmlsatuanbesar { get; set; }
        public decimal? hargapersatuanbesar { get; set; }
        public short? jmlsatuankecil { get; set; }
        public decimal? hargapersatuankecil { get; set; }
        public DateTime? tglkadaluarsa { get; set; }
        public short aptbarangmasukid { get; set; }
        public DateTime? tglmasukpembelian { get; set; }
        public string nobeli { get; set; }
        public decimal? totalpembelian { get; set; }
        public string ketpembelian { get; set; }
        public bool? isstock { get; set; }
        public short aptstockopgudangdetailid { get; set; }
        public decimal? hargapph { get; set; }
        public decimal? harga35 { get; set; }
        public decimal? hargatoeslag { get; set; }
        public decimal? hargajual { get; set; }
        public short? jmlsatuankecilout { get; set; }
        public short aptstockopgudangid { get; set; }
        public DateTime? tglstock { get; set; }
        public string ketgudang { get; set; }
        public short? loginid { get; set; }

        public string tahunstock { get; set; }
        public string bulanstock { get; set; }

        public short aptgudangid { get; set; }
        public string ruangrawatnm { get; set; }
        public byte aptstsstockid { get; set; }
        public string aptstsstocknm { get; set; }
    }

}
