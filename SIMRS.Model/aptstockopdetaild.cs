using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class aptstockopdetaild
    {
        public short aptstockopdetailid { get; set; }
        public short? aptstockopid { get; set; }
        public short? aptbrggudetailid { get; set; }
        public short? jmlstock { get; set; }
        public bool? isonline { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }
        public bool? sts { get; set; }
    }



}
