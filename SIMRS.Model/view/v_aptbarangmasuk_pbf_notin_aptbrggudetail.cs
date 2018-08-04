using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model.view
{
    public class v_aptbarangmasuk_pbf_notin_aptbrggudetail
    {
        public short aptbarangmasukid { get; set; }
        public byte? aptpbfid { get; set; }
        public DateTime? tglmasuk { get; set; }
        public DateTime? jammasuk { get; set; }
        public string tahun { get; set; }
        public string bulan { get; set; }
        public string nobeli { get; set; }
        public decimal? dpp { get; set; }
        public decimal? ppn { get; set; }
        public decimal? biayakirim { get; set; }
        public decimal? materai { get; set; }
        public byte? potonganpersen { get; set; }
        public decimal? potongannominal { get; set; }
        public decimal? total { get; set; }
        public string ket { get; set; }
        public bool? isstock { get; set; }
        public bool? sts { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public string aptpbfnm { get; set; }
    }

}
