using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class icdxpuskesmas
    {
        public short icdxpuskesmasid { get; set; } // smallint, not null
        public string icdxpuskesmaskode { get; set; } // varchar(10), null
        public string icdxpuskesmasnama { get; set; } // varchar(120), null
        public DateTime? created_date { get; set; } // datetime, null
        public DateTime? updated_date { get; set; } // datetime, null
        public bool? icdxpuskesmassts { get; set; } // bit, null
    }

}
