using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class aptstockopgudangdetail
    {
        public short aptstockopgudangdetailid { get; set; }
        public short? aptstockopgudangid { get; set; }
        public short? aptbarangmasukdetailid { get; set; }
        public short? jmlsatuanbesar { get; set; }
        public short? jmlsatuankecil { get; set; }
        public DateTime? tglkadaluarsa { get; set; }
        public decimal? hargapph { get; set; }
        public decimal? harga35 { get; set; }
        public decimal? hargatoeslag { get; set; }
        public decimal? hargajual { get; set; }
        public short? jmlsatuankecilout { get; set; }
        public short? loginid { get; set; }
        public bool? sts { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updatedate { get; set; }
    }

}
