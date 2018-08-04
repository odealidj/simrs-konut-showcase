using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_aptdistribusidetail
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
        public DateTime? tglkadaluarsa { get; set; }
        public short aptstockopgudangdetailid { get; set; }
        public decimal? hargajual { get; set; }
        public short aptstockopgudangid { get; set; }
        public short aptgudangid { get; set; }
        public string gudangnm { get; set; }
        public short aptdistribusidetailid { get; set; }
        public short? jmlsatuanbesar { get; set; }
        public short? jmlsatuankecil { get; set; }
        public short? jmlsatuankecilout { get; set; }
        public short aptdistribusiid { get; set; }
        public DateTime? tgldistribusi { get; set; }
        public string ketdistribusi { get; set; }
        public bool? online { get; set; }
        public short? loginid { get; set; }
        public short? aptdepoidasal { get; set; }
        public string deponmasal { get; set; }
        public short? aptdepoidtujuan { get; set; }
        public string deponmtujuan { get; set; }
        public string tahundistribusi { get; set; }
        public string bulandistribusi { get; set; }
    }

}
