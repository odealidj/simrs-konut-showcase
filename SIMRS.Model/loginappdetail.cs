using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class loginappdetail
    {
        public short loginappdetailid { get; set; } // smallint, not null
        public string loginappdetailnik { get; set; } // varchar(25), null
        public string loginappdetailnm { get; set; } // varchar(50), null
        public short? jkid { get; set; } // smallint, null
        public string loginappdetaidepartmen { get; set; } // varchar(50), null
        public bool? sts { get; set; } // bit, null
        public DateTime? created_date { get; set; } // datetime, null
        public DateTime? updated_date { get; set; } // datetime, null
        public bool? loginappdetailsts { get; set; } // bit, null
    }
}
