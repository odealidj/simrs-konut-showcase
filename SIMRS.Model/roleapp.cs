using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class roleapp
    {
        public short roleappid { get; set; } // smallint, not null
        public string roleappnm { get; set; } // varchar(20), null
        public bool? roleappsts { get; set; } // bit, null
    }
}
