using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_aptpembeliandetail
    {
        public short aptbarangid { get; set; }
        public string aptbarangnm { get; set; }
        public short aptpbfid { get; set; }
        public string aptpbfnm { get; set; }
        public short aptbarangsatuanid { get; set; }
        public short? jmlsatuankecil { get; set; }
        public string satuankecilkode { get; set; }
        public short? jmlsatuanbesar { get; set; }
        public string satuanbesarkode { get; set; }
        public string defenisisatuan { get; set; }
        public short aptbarangmasukdetailid { get; set; }
        public string kodebarangpbf { get; set; }
        public DateTime? tglkadaluarsa { get; set; }
        public string nobatch { get; set; }
        public short? qty { get; set; }

        public decimal? hargasatuan { get; set; }
        public double? potonganpersen { get; set; }

        public decimal? hargasatuanpot { get; set; }
        public decimal? jmlharga { get; set; }
        public string stskb { get; set; }
        public string aptsatuankode { get; set; }
        public short aptbarangmasukid { get; set; }
        public DateTime? tglmasuk { get; set; }
        public string tahunbeli { get; set; }
        public string bulanbeli { get; set; }
        public string nobeli { get; set; }
        public decimal? dpp { get; set; }
        public decimal? ppn { get; set; }
        public decimal? biayakirim { get; set; }
        public decimal? materai { get; set; }
        public decimal? total { get; set; }
        public short? isstock { get; set; }
        public byte aptstsbrgmasukdetailid { get; set; }
        public string aptstsbrgmasukdetailnm { get; set; }
    }





}
