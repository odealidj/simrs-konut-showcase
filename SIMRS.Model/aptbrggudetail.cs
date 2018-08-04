using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class aptbrggudetail
    {
        public short aptbrggudetailid { get; set; }
        public short? aptbrgguid { get; set; }
        public decimal? hargaskecil { get; set; }
        public decimal? hargapph { get; set; }
        public decimal? harga35 { get; set; }
        public decimal? hargatoeslag { get; set; }
        public decimal? hargajual { get; set; }
        public bool? sts { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updatedate { get; set; }
    }


}
