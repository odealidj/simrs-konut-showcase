using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class aptbarangmasukdetail
    {
        public short aptbarangmasukdetailid { get; set; }
        public short? aptbarangsatuanid { get; set; }
        public short? aptbarangmasukid { get; set; }
        public string kodebarangpbf { get; set; }
        public DateTime? tglkadaluarsa { get; set; }
        public string nobatch { get; set; }
        public string aptsatuankode { get; set; }
        public short? qty { get; set; }
        public decimal? hargasatuan { get; set; }
        public double? potonganpersen { get; set; }
        public decimal? hargasatuanpot { get; set; }
        public decimal? jmlharga { get; set; }
        public string stskb { get; set; }
        public short? aptstsbrgmasukdetailid { get; set; }
        public bool? sts { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }
    }




}
