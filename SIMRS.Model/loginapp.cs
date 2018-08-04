using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class loginapp
    {
        public short loginappid { get; set; } // smallint, not null
        public string loginappuser { get; set; } // varchar(12), null
        public string loginapppasswd { get; set; } // varchar(12), null
        public short? roleappid { get; set; } // smallint, null
        public DateTime? created_date { get; set; } // datetime, null
        public DateTime? updated_date { get; set; } // datetime, null
        public bool? loginappsts { get; set; } // bit, null
    }


}
