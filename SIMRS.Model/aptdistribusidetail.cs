using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class aptdistribusidetail
    {
        public short aptdistribusidetailid { get; set; }
        public short? aptdistribusiid { get; set; }
        public short? aptstockopdetailid { get; set; }
        public short? jmlstock { get; set; }
        public short? loginid { get; set; }
        public bool? sts { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updatedate { get; set; }
    }


}
