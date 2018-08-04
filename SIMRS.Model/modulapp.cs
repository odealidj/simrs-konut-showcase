using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class modulapp
    {
        public string modulappkode { get; set; } // varchar(10), not null
        public short? pelayananmedikid { get; set; } // smallint, null
        public string modulappnm { get; set; } // varchar(50), null
        public string modulappdesk { get; set; } // varchar(200), null
        public DateTime? created_date { get; set; } // datetime, null
        public DateTime? updated_date { get; set; } // datetime, null
        public bool? modulappsts { get; set; } // bit, null
    }


}
