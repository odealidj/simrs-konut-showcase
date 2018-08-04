using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Model
{
    public class rt
    {
        public short rtid { get; set; } // smallint, not null
        public short? rwid { get; set; } // smallint, null
        public string rtnm { get; set; } // varchar(4), null
        public bool? rtsts { get; set; } // bit, null
    }

}
