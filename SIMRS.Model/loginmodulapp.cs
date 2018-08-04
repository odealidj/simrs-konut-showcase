using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class loginmodulapp
    {
        public short loginmodulappid { get; set; } // smallint, not null
        public short? loginappid { get; set; } // smallint, null
        public string modulappkode { get; set; } // varchar(10), null
        public DateTime? created_date { get; set; } // datetime, null
        public DateTime? updated_date { get; set; } // datetime, null
        public bool? loginmodulappsts { get; set; } // bit, null
    }

}
